import pandas as pd
from bs4 import BeautifulSoup
import re
import sys
from concurrent.futures import ThreadPoolExecutor

sys.path.append("d:/pro/py/pycpro1/utils/content_count_and_url_lazy")
from lazy import get_and_save_page_source_once

def check_bio_exist(url): 
    page_source = get_and_save_page_source_once(url)
    page_text = BeautifulSoup(page_source, 'html.parser').text.lower()

    words = [""]

    words_set = set(words)
    for page_word in page_text.split():
        if page_word in words_set:
            print(page_word, url)
            return True

    processed_page_source = page_source.replace(" ", "").lower()
    for i in range(len(processed_name) - substring_length + 1):
        temp_name = processed_name[i:i + substring_length]
        if temp_name in processed_page_source:
            return True
    return False




def get_age_from_url(url):
    """
    从指定的URL的网页源代码中提取年龄信息。
    
    参数:
    - url (str): 目标网址。

    返回:
    - int/None: 如果找到年龄信息，则返回该年龄的整数值，否则返回None。
    """
    page_source = get_and_save_page_source_once(url)
    soup = BeautifulSoup(page_source, 'lxml')
    full_text = soup.get_text()
    words = full_text.lower().split()

    # 数字到它们英文单词表示的映射
    number_words = {
        "one": 1, "two": 2, "three": 3, "four": 4, "five": 5,
        "six": 6, "seven": 7, "eight": 8, "nine": 9, "ten": 10,
        "eleven": 11, "twelve": 12, "thirteen": 13, "fourteen": 14,
        "fifteen": 15, "sixteen": 16, "seventeen": 17, "eighteen": 18,
        "nineteen": 19, "twenty": 20
    }

    # 包含年龄信息的关键词
    key_words = ["child", "children", "age", "ages", "years", "old"]

    # 遍历每个关键词并检查其前后的单词以提取可能的年龄信息
    for key_word in key_words:
        occurrences = [i for i, word in enumerate(words) if word == key_word]
        for child_index in occurrences:
            start = max(0, child_index - 10)
            end = min(len(words), child_index + 10)
            for i in range(start, end):
                # 如果单词是数字，则返回该数字
                if words[i].isdigit():
                    return int(words[i])
                # 如果单词包含数字范围，则返回范围的开始数字
                elif "-" in words[i] and words[i].split("-")[0].isdigit():
                    return int(words[i].split("-")[0])
                # 如果单词是数字的英文表示，则返回相应的数字
                elif words[i] in number_words:
                    return number_words[words[i]]
    return None


def process_row(row):
    try:
        """
        对于给定的行，执行check_name_exist和get_age_from_url函数，并返回结果。
        """
        name_exists = check_name_exist(row["name"], row["privacy_url"])
        extracted_age = get_age_from_url(row["privacy_url"])
        return name_exists, extracted_age
    except:
        return "", ""

if __name__ == "__main__":
    # 1. 读取CSV文件
    df = pd.read_csv("d:/pro/py/pycpro1/exper/category/processed_merged_platform_data.csv")

    # 2. 使用ThreadPoolExecutor并行处理
    with ThreadPoolExecutor(max_workers=8) as executor:
        results = list(executor.map(process_row, df.to_dict('records')))

    df["name_exists"], df["extracted_age"] = zip(*results)

    # 3. 保存更新后的DataFrame
    df.to_csv("updated_processed_merged_platform_data.csv", index=False)