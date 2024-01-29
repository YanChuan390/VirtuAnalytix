from selenium import webdriver
from selenium.webdriver.common.by import By
from concurrent.futures import ThreadPoolExecutor
from selenium.webdriver.chrome.options import Options
import time, sys, os
import shutil
import tempfile
import os

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

def write_to_file(filename, text):
    with open(filename, 'w', encoding='utf-8') as f:
        f.write(text)

# def create_driver_instance(thread_id):
#     temp_dir = tempfile.mkdtemp(prefix=f"chrome_temp_{thread_id}_")
#     shutil.copytree("C:/Users/Administrator/AppData/Local/Google/Chrome/User Data", os.path.join(temp_dir, "User Data"))

#     chrome_options = Options()
#     chrome_options.add_argument(f"user-data-dir={temp_dir}/User Data")

#     driver = webdriver.Chrome(options=chrome_options)
#     driver.set_page_load_timeout(60)

#     return driver

def check_p_tags_for_string(driver, target_string=""):
    p_elements = driver.find_elements(By.TAG_NAME, "p")
    for p in p_elements:
        text = p.text
        if target_string in text:
            return True
    return False

def gg(w):
    try:
        url, p = w
        path = os.path.join(".", "res34", p)
        if os.path.isfile(path):
            print(f"file: {path} exist!")
            return
        chrome_options = Options()
        chrome_options.add_argument("user-data-dir=C:/Users/Administrator/AppData/Local/Google/Chrome/User Data")
        driver = webdriver.Chrome(options=chrome_options)
        # driver = webdriver.Chrome()
        driver.set_page_load_timeout(70)
        driver.get(url)
        if check_p_tags_for_string(driver, "请选择您的出生日期"):
            with open("gaoji.txt", 'a', encoding='utf-8') as f:
                print("gaoji", url, p, file = f)
            return

        # 游戏名 css-1jas5id
        elements = driver.find_elements(By.CLASS_NAME, "css-1jas5id")
        name = get_element_info_or_null(elements[0])[1]

        cur_file = open(path, 'w', encoding='utf-8')
        print('tag', "|||".join(["name", name]), file=cur_file, flush=True)

        # 游戏简介 css-yz8uts[0]
        elements = driver.find_elements(By.CLASS_NAME, "css-yz8uts")
        jj = get_element_info_or_null(elements[0])[1]
        print('tag', "|||".join(["jj", jj.replace('\n', ' ')]), file=cur_file, flush=True)

        #本页的url
        url = driver.current_url
        print('tag', "|||".join(["url", url]), file=cur_file, flush=True)

        #语言支持
        parent_element = driver.find_element(By.CLASS_NAME, "css-1dwnhji")
        child_elements = parent_element.find_elements(By.XPATH, "./*")
        lan = []
        for child in child_elements:
            lan.append((child.tag_name, child.text))
        while len(lan) > 4:
            lan = lan[4:]
            now = [] # 中文 true false false
            now.append(lan[0][1])
            for i in range(1, 4):
                now.append(str(lan[i][0] == 'div'))
            
            print('tag', "|||".join(["language_support", "^^".join(now)]), file=cur_file, flush=True)

        #一般化情况
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
            print("tag", "|||".join(print_parts).replace("\n", ", "), file=cur_file, flush=True)
        driver.quit()
    except Exception as e:
        print("err")
        # !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        # return
        sys.exit(0)

def main1(arg):
    pref = "https://www.viveport.com/apps/"
    with open("suf.txt", "r") as f:
        lines = f.readlines()

    full = []
    for i in range(len(lines)):
        l = lines[i].strip()
        full.append((pref + l, l + arg))

    print(full)
    with ThreadPoolExecutor(max_workers=1) as executor:
        executor.map(gg, full, chunksize=1)

print(os.getcwd())
main1("_3")

# if __name__ == "__main__":
#     pref = "https://www.viveport.com/apps/"
#     # f(pref + "86f31ef6-2c72-44f6-8228-4ed662fc9732")
#     with open("suf1.txt", "r") as f:
#         lines = f.readlines()
#     for i in range(len(lines) * 0 + 1):
#         print(f'now {i} {pref + lines[i]} !!!!!!!!!!!!!!', flush=True)
#         gg(pref + lines[i])
