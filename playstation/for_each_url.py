import os
import time
from concurrent.futures import ThreadPoolExecutor
from bs4 import BeautifulSoup
import sys
import re
import csv

sys.path.append("d:/pro/py/pycpro1/utils/content_count_and_url_lazy/")

from lazy import get_and_save_page_source_once

def find_element_by_tag_and_class(soup, tag, class_name):
    try:
        return soup.find(tag, class_=class_name)
    except:
        return ""

def get_name(soup):
    try:
        element = find_element_by_tag_and_class(soup, "h1", "psw-t-title-l")
        return element.text
    except:
        return ""

def get_description(soup):
    try:
        element = find_element_by_tag_and_class(soup, "p", "psw-c-bg-card-1")
        return element.text.replace("\n", " ")
    except:
        return ""

def get_privacy_policy(soup):
    try:
        element = find_element_by_tag_and_class(soup, "a", "dtm-track")
        res = element["href"]
        if not res.startswith("#all"):
            return res
        return ""
    except:
        return ""

def extract_genre(soup):
    # 找到tag名为dt且其text为"Genre:"的元素
    dt_element = soup.find('dt', string='Genre:')

    # 如果找到了该元素，那么获取其下一个兄弟元素
    if dt_element:
        next_sibling = dt_element.find_next_sibling()

        if next_sibling:
            span_element = next_sibling.find('span')
            if span_element:
                return span_element.text
    return ""

def get_age_limit(soup):
    page_text = str(soup)
    pattern = re.compile(r'iarc_(\d+)\.png')
    match = re.search(pattern, page_text)
    if match:
        return match.group(1)
    return ""

def process_url_past(url_cnt):
    time.sleep(1)
    url, cnt = url_cnt

    file_path = os.path.join(".", "res", cnt + ".txt")
    print(file_path)
    with open(file_path, 'a', encoding='utf-8') as f:
        html_source = get_and_save_page_source_once(url)
        soup = BeautifulSoup(html_source, 'html.parser')
        print("tag_num", cnt, file=f)
        print("tag_name", get_name(soup), file=f)
        print("tag_jj", get_description(soup), file=f)
        print("tag_pp", get_privacy_policy(soup), file=f)
        print("tag_genre", extract_genre(soup), file=f)
        print("tag_age", get_age_limit(soup), file=f)
        print("origin_url", url, file=f)

def process_url(url_cnt):
    time.sleep(1)
    url, cnt = url_cnt

    file_path = os.path.join(".", "res", cnt + ".txt")
    print(file_path)
    with open(file_path, 'a', encoding='utf-8') as f:
        html_source = get_and_save_page_source_once(url)
        if "copyright" in html_source.lower() or "copy right" in html_source.lower() or "copy_right" in html_source.lower():
            print("yes")
        else:
            print("no")
        soup = BeautifulSoup(html_source, 'html.parser')

        # 准备数据
        data = {
            "order": cnt,
            "name": get_name(soup),
            "description": get_description(soup),
            "privacy_policy": get_privacy_policy(soup),
            "genre": extract_genre(soup),
            "age": get_age_limit(soup),
            "origin_url": url
        }

        # 写入文本文件
        for key, value in data.items():
            print(key, value, file=f)

        # 写入 CSV 文件
        with open('output.csv', mode='a', encoding='utf-8', newline='') as csv_file:
            fieldnames = data.keys()
            writer = csv.DictWriter(csv_file, fieldnames=fieldnames)

            # 如果文件是新的，写入 header
            if csv_file.tell() == 0:
                writer.writeheader()
            writer.writerow(data)

if __name__ == "__main__":
    lines = []

    with open("url/urls.txt", "r", encoding='utf-8') as f:
        for index, line in enumerate(f.readlines()):
            stripped_line = line.strip()
            lines.append((stripped_line, str(index + 1)))

    with ThreadPoolExecutor(max_workers=30) as executor:
        executor.map(process_url, lines, chunksize=1)

# process_url(("https://store.playstation.com/en-sg/product/EP4365-CUSA14474_00-SKIJUMPINGPROVR1", str(0)))