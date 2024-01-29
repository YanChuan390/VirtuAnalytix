from bs4 import BeautifulSoup
from concurrent.futures import ThreadPoolExecutor
import os, sys
import re

sys.path.append("d:/pro/py/pycpro1/utils/content_count_and_url_lazy/")
from lazy import get_and_save_page_source_once

def get_element_text_or_null(element, tag):
    try:
        return element.find(tag).text.strip()
    except:
        return "null"

def get_element_attribute_or_null(element, tag, attribute):
    try:
        return element.find(tag)[attribute].strip()
    except:
        return "null"

def get_element_info_or_null(element):
    try:
        return element.name, element.text.strip()
    except:
        return "null", "null"

def extract_genre_names(soup):
    pattern = re.compile(r'^/filter-page/app\?genre=\d+$')
    genre_names = [a.text for a in soup.find_all('a', href=pattern)]
    return genre_names

def process_one(w):
    url, file_suffix = w
    hash_code = url.split('/')[-1]
    write_to_path = os.path.join(".", "res34", f"{hash_code}{file_suffix}")

    print(url, file_suffix, write_to_path)

    page_source = get_and_save_page_source_once(url)
    soup = BeautifulSoup(page_source, 'html.parser')

    with open(write_to_path, 'w', encoding='utf-8') as cur_file:

        # 获取游戏名 css-1jas5id
        element = soup.find(class_="css-1jas5id")
        name = get_element_info_or_null(element)[1]
        print('tag', "|||".join(["name", name]), file=cur_file)

        # 获取游戏简介 css-yz8uts
        element = soup.find(class_="css-yz8uts")
        jj = get_element_info_or_null(element)[1]
        print('tag', "|||".join(["jj", jj.replace('\n', ' ')]), file=cur_file)

        # 获取游戏的标签
        genres_list = extract_genre_names(soup)
        genres_str = ' '.join(genres_list)
        print("tag", "|||".join(["genres", genres_str]), file=cur_file)

        # 游戏原来的url
        print('tag', "|||".join(["url", url]), file=cur_file)

        elements = soup.find_all(class_="css-1r3yzap")
        for element in elements:
            p = get_element_text_or_null(element, "p")
            div = get_element_text_or_null(element, "div")
            a = get_element_text_or_null(element, "a")
            a_href = get_element_attribute_or_null(element, "a", "href")

            print_parts = []

            if p != "null":
                u = f"{p}"
                if len(u):
                    print_parts.append(u)
            if div != "null":
                print_parts.append(f"{div}")
            if a != "null":
                print_parts.append(f"{a}")
            if a_href != "null":
                print_parts.append(f"{a_href}")

            for i in range(len(print_parts)):
                for u in ["隐私政策", "使用条款"]:
                    if u in print_parts[i]:
                        print_parts[i] = u
                        break

            print("tag", "|||".join(print_parts).replace("\n", ", "), file=cur_file)

    with open(write_to_path, 'r', encoding='utf-8') as cur_file:
        if len(cur_file.readlines()) < 7:
            with open("./bad_urls.txt", "a", encoding="utf-8") as f:
                f.write(url + "\n")

def for_each_url(process_tag):
    urls = []
    with open("./url/urls.txt", "r", encoding="utf-8") as f:
        for url in f.readlines():
            urls.append((url.strip(), process_tag))

    # urls = urls[0:10]

    with ThreadPoolExecutor(max_workers=30) as executor:
        executor.map(process_one, urls)

for_each_url("_4")
# # https://www.viveport.com/apps/0b1cf65b-8d1d-4d4e-be9d-9f4b74050d1b