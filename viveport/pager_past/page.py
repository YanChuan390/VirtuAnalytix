from selenium import webdriver
from selenium.webdriver.common.by import By
from concurrent.futures import ThreadPoolExecutor
import time, sys, os

def get_element_text_or_null(element, tag):
    try:
        return element.find_element(By.TAG_NAME, tag).text
    except:
        return "null"

def get_element_attribute_or_null(element, tag, attribute):
    try:
        return element.find_element(By.TAG_NAME, tag).get_attribute(attribute)
    except:
        return "null"

def get_element_info_or_null(e):
    try:
        return e.tag_name, e.text
    except:
        return "null", "null"

def process_one(w):
    try:
        url, file_suffix = w
        path = os.path.join(".", "res34", file_suffix)

        cur_file = open(path, 'w', encoding='utf-8')
        cur_file = open("./temp.txt", "w", encoding="utf-8")

        driver = webdriver.Chrome()
        driver.set_page_load_timeout(60)
        driver.get(url)

        # 游戏名 css-1jas5id
        elements = driver.find_elements(By.CLASS_NAME, "css-1jas5id")
        name = get_element_info_or_null(elements[0])[1]
        print('tag', "|||".join(["name", name]), file=cur_file)

        # 游戏简介 css-yz8uts[0]
        elements = driver.find_elements(By.CLASS_NAME, "css-yz8uts")
        jj = get_element_info_or_null(elements[0])[1]
        print('tag', "|||".join(["jj", jj.replace('\n', ' ')]), file=cur_file)

        url = driver.current_url
        print('tag', "|||".join(["url", url]), file=cur_file)

        elements = driver.find_elements(By.CLASS_NAME, "css-1r3yzap")
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
        driver.quit()
    except Exception as e:
        print("err")
        return

def for_each_url(process_tag):
    urls = []
    with open("./url/urls.txt", "r", encoding="utf-8") as f:
        for url in f.readlines():
            urls.append((url.strip(), process_tag))

    with ThreadPoolExecutor(max_workers=5) as executor:
        executor.map(process_one, urls)

for_each_url("_4")
# https://www.viveport.com/apps/0b1cf65b-8d1d-4d4e-be9d-9f4b74050d1b