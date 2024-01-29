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

    words = ["environment", "face", "body", "biome", "physical", "finger", "behavioral", "face", "iris", 
    "voice", "gender", "height", "weight", "surveillance", "DNA", "Retina", "Palm",
    "Ear", "signature", "handwriting", "Vein", "skin", "Authen", "Verifi",
    "Identi", "gait"]


    words_set = set(words)
    for word in words:
        for page_word in page_text.split():
            if page_word != "facebook":
                if word in page_word:
                    print(word, page_word, url)
                    return True
    return False

def get_age_from_url(url):
    return None

def process_row(row):
    try:
        if row["privacy_url"] and len(row["privacy_url"]) > 5:
            bio_exists = check_bio_exist(row["privacy_url"])
            extracted_age = get_age_from_url(row["privacy_url"])
            return bio_exists, extracted_age
        else:
            return "", ""
    except:
        return "", ""

if __name__ == "__main__":
    # 1. 读取CSV文件
    df = pd.read_csv("d:/pro/py/pycpro1/exper/category/processed_merged_platform_data.csv")

    # 2. 使用ThreadPoolExecutor并行处理
    with ThreadPoolExecutor(max_workers=8) as executor:
        results = list(executor.map(process_row, df.to_dict('records')))

    df["bio_exists"], df["extracted_age"] = zip(*results)

    # 3. 保存更新后的DataFrame
    df.to_csv("updated_processed_merged_platform_data_bio.csv", index=False)