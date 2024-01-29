import os
import hashlib
from selenium import webdriver
import time
import concurrent.futures
import sys
from check_remove_page_source import check_and_remove
from selenium.webdriver.chrome.options import Options
import datetime
import random
import requests
import PyPDF2
from io import BytesIO

sys.path.append("D:/pro/py/pycpro1/utils/content_count_and_url_lazy")

dps ="d:/pro/py/pycpro1/utils/content_count_and_url_lazy/page_sources"

def generate_filename(url):
    return hashlib.md5(url.encode()).hexdigest() + ".txt"

def get_url_save_path(url, directory=dps):
    filename = generate_filename(url)
    filepath = os.path.join(directory, filename)
    return filepath

def is_file_modified_today(url, directory=dps):
    filename = generate_filename(url)
    filepath = os.path.join(directory, filename)

    if not os.path.exists(filepath):
        return False
    
    timestamp = os.path.getmtime(filepath)
    modified_time = datetime.datetime.fromtimestamp(timestamp)
    current_time = datetime.datetime.now()
    return modified_time.date() == current_time.date()

def save_page_source(url, page_source, directory=dps, is_jump=False):
    if not os.path.exists(directory):
        os.makedirs(directory)
    
    filename = generate_filename(url)
    filepath = os.path.join(directory, filename)
    
    if not is_jump:
        if os.path.exists(filepath):
            with open(filepath, 'r', encoding='utf-8') as file:
                existing_content = file.read()
                if len(existing_content) >= len(page_source):
                    return

    with open(filepath, 'w', encoding='utf-8') as file:
        file.write(page_source)

def check_is_saved(url, directory=dps):
    filename = generate_filename(url)
    filepath = os.path.join(directory, filename)
    return os.path.exists(filepath)

# 访问并保存url的page_source, 按照长度替换
def get_and_save_page_source(url, directory=dps):
    chrome_options = webdriver.ChromeOptions()
    chrome_options.add_argument("--lang=en")
    driver = webdriver.Chrome(options=chrome_options)
    driver.set_page_load_timeout(60)
    try:
        driver.get(url)
    except:
        pass
    time.sleep(2)
    page_source = driver.page_source
    save_page_source(url, page_source, directory)
    return page_source

def get_pdf_text_as_html(url):
    response = requests.get(url)
    response.raise_for_status()

    print("here", url, file=open("temp.txt", "a", encoding="utf-8"))

    with BytesIO(response.content) as open_pdf_file:
        reader = PyPDF2.PdfFileReader(open_pdf_file)
        text = ""
        for page_num in range(reader.numPages):
            text += reader.getPage(page_num).extractText()
        
        # 转换文本为HTML
        html_content = f"<html><head><title>PDF content from {url}</title></head><body>{text}</body></html>"
    save_page_source(url, html_content)
    print(html_content, file=open("temp.txt", "a", encoding="utf-8"))
    return html_content


# 对一个txt中的所有url并行执行
def get_and_save_page_source_for_txt(txt_paths, max_work=6):
    print("txt_paths", txt_paths)
    urls = []
    for txt_path in txt_paths:
        with open(txt_path, "r", encoding="utf-8") as f:
            for url in f.readlines():
                urls.append(url.strip())
    
    random.shuffle(urls)

    with concurrent.futures.ThreadPoolExecutor(max_workers=max_work) as executor:
        # executor.map(get_and_save_page_source, urls)
        executor.map(get_and_save_page_source_once, urls)


def get_page_source_from_file(url, directory=dps):
    filename = generate_filename(url)
    filepath = os.path.join(directory, filename)
    if not check_is_saved(url, directory):
        return ""
    with open(filepath, 'r', encoding='utf-8') as file:
        return file.read()

# 检查某个url的page_source是否已经保了
# 如果没有再执行爬虫
def get_and_save_page_source_once(url, directory=dps):
    if not check_is_saved(url):
        return get_and_save_page_source(url, directory)
    else:
        return get_page_source_from_file(url, directory)

# 删掉某个url对应的page_source
def delete_local_file_of_url(url, directory=dps):
    while (check_is_saved(url, directory)):
        filename = generate_filename(url)
        filepath = os.path.join(directory, filename)
        os.remove(filepath)

def delete_local_file_of_url_for_txt(file_path, directory=dps):
    with open(file_path, 'r', encoding="utf-8") as f:
        urls = f.readlines()
    
    for url in urls:
        url = url.strip()
        delete_local_file_of_url(url, directory)






def get_and_save_page_source_for_txt_for_pdf(txt_paths, max_work=6):
    urls = []
    for txt_path in txt_paths:
        with open(txt_path, "r", encoding="utf-8") as f:
            for url in f.readlines():
                url = url.strip()
                if url.endswith(".pdf"):
                    delete_local_file_of_url(url)
                    urls.append(url)
    
    random.shuffle(urls)

    with concurrent.futures.ThreadPoolExecutor(max_workers=max_work) as executor:
        executor.map(get_pdf_text_as_html, urls)

if __name__ == "__main__":
    get_and_save_page_source_for_txt_for_pdf(["d:/pro/py/pycpro1/exper/category/privacy_urls.txt"])
