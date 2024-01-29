import os
from selenium import webdriver
from selenium.webdriver.common.by import By
import time, os

microsft_path = "d:/pro/py/pycpro1/microsoft/"
urls_path = os.path.join(microsft_path, "urls/urls.txt")
result1_save_path = os.path.join(microsft_path, "type1_result/")
result2_save_path = os.path.join(microsft_path, "type2_result/")

def get_txt_filenames(directory_path):
    txt_files = [f for f in os.listdir(directory_path) if f.endswith('.txt')]
    return ' '.join(txt_files)

# 两种url类型
def get_type012(url):
    if "?" not in url:
        url += "?hl=en-us&gl=us"
    app_hash = url.split('?')[-2].split('/')[-1] # '?'号前面，'/'后面的部分

    file_names1 = get_txt_filenames(result1_save_path)
    file_names2 = get_txt_filenames(result2_save_path)

    if app_hash in file_names1:
        return 1
    elif app_hash in file_names2:
        return 2
    return 0

if __name__ == "__main__":
    urls = []
    with open(urls_path, "r", encoding="utf-8") as f:
        for i in f.readlines():
            urls.append(i.strip())
    urls = urls[0:10]
    for url in urls:
        print(url, get_type012(url))