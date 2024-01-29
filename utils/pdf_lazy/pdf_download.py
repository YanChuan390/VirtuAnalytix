import sys
import os
import time
from selenium import webdriver
import shutil
import pandas as pd
import random
import PyPDF2

sys.path.append("d:/pro/py/pycpro1/utils/content_count_and_url_lazy")
from lazy import generate_filename

def download_pdf_once(pdf_url):
    # 生成文件名
    new_filename = generate_filename(pdf_url) + '.pdf'
    new_filepath = os.path.join('./pdfs/', new_filename)

    # 如果文件已存在，跳过下载
    if os.path.exists(new_filepath):
        print(f"File {new_filename} already exists. Skipping download.")
        return

    # 指定下载目录
    download_folder = os.path.expanduser('~/Downloads')  # 通常这是默认下载目录
    chrome_options = webdriver.ChromeOptions()

    # 配置Chrome以不显示PDF，而是直接下载
    prefs = {
        'download.prompt_for_download': False,  # 不提示选择保存位置
        'download.directory_upgrade': True,
        'plugins.always_open_pdf_externally': True  # 不在浏览器中打开PDF
    }
    chrome_options.add_experimental_option('prefs', prefs)

    # 启动Chrome浏览器
    driver = webdriver.Chrome(options=chrome_options)
    driver.set_page_load_timeout(30)

    # 导航到PDF的URL，这将自动下载PDF
    driver.get(pdf_url)
    time.sleep(10)  # 增加等待时间确保文件完全下载
    driver.quit()

    # 移动并重命名下载的PDF
    original_file_path = os.path.join(download_folder, pdf_url.split('/')[-1])
    shutil.move(original_file_path, new_filepath)


def get_pdf_content_from_local_file(pdf_path):
    content = ""
    with open(pdf_path, 'rb') as file:
        reader = PyPDF2.PdfReader(file)
        for page_num in range(len(reader.pages)):
            page = reader.pages[page_num]
            content += page.extract_text()
    return content

def get_content_of_pdfurl_online(pdf_url):
    download_pdf_once(pdf_url)

    # 确定文件的本地路径
    new_filename = generate_filename(pdf_url) + '.pdf'
    new_filepath = os.path.join('./pdfs/', new_filename)

    # 如果文件存在，提取其内容
    if os.path.exists(new_filepath):
        return get_pdf_content_from_local_file(new_filepath)
    else:
        return ""

def get_content_of_pdfurl_offline(pdf_url):
    new_filename = generate_filename(pdf_url) + '.pdf'
    new_filepath = os.path.join('./pdfs/', new_filename)
    if os.path.exists(new_filepath):
        return get_pdf_content_from_local_file(new_filepath)
    else:
        return ""

def wrap_content_in_html(content, title="PDF Content"):
    html_template = f"""
    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>{title}</title>
    </head>
    <body>
        <div>
            {content}
        </div>
    </body>
    </html>
    """
    return html_template

def test_random_pdf_content(directory="./pdfs/"):
    all_files = os.listdir(directory)
    pdf_files = [f for f in all_files if f.endswith('.pdf')]
    if not pdf_files:
        return "No PDF files found in the directory."
    
    chosen_file = random.choice(pdf_files)
    chosen_file_path = os.path.join(directory, chosen_file)
    return get_pdf_content_from_local_file(chosen_file_path)

# pdf_content = test_random_pdf_content()
# print(pdf_content)





def process_csv_and_download_pdfs(csv_path):
    # 读取CSV文件
    df = pd.read_csv(csv_path)

    # 筛选出privacy_url列
    privacy_urls = df['privacy_url'].dropna().tolist()  # 去除NaN值

    for url in privacy_urls:
        if url.endswith('.pdf'):
            print(f"Downloading {url} ...")
            try:
                download_pdf_once(url)
                print(f"Successfully downloaded {url}!")
            except Exception as e:
                print(f"Error downloading {url}. Reason: {e}")

if __name__ == "__main__xxx":
    # 调用函数
    process_csv_and_download_pdfs('d:/pro/py/pycpro1/exper/category/processed_merged_platform_data.csv')
