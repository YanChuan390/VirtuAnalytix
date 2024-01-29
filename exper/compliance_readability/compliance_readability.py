import pandas as pd
from bs4 import BeautifulSoup
import re
import sys
from concurrent.futures import ThreadPoolExecutor

import nltk
nltk.download('punkt')

sys.path.append("d:/pro/py/pycpro1/exper/part_extractor/src/compliance of disclosure/")
from compliance_of_disclosure import all_process_dict_url

sys.path.append("d:/pro/py/pycpro1/exper/part_extractor/src/readability/")
from readability import analyze_url

sys.path.append("d:/pro/py/pycpro1/utils/content_count_and_url_lazy")
from lazy import get_and_save_page_source_once

import pandas as pd
from concurrent.futures import ThreadPoolExecutor

def process_url(url):
    # 对于URL执行 all_process_dict_url
    process_result = all_process_dict_url(url)
    # 执行 analyze_url
    analyze_result = analyze_url(url)
    # 合并两个结果并返回
    re = {**process_result, **analyze_result}
    page_source = get_and_save_page_source_once(url).lower()
    default_dict = {
        'type': ["collect"], 'cookie': 0, 'share': 0, 'security': 0, 'right': 0,
        'children': ["kid", "child"], 'specialArea': ["region"], 'update': 0, 'how': 0,
        'provide': 0, 'retention': 0, 'useData': ["use"], 'order': "N",
        'label_error': 0, 'title_error': 0
    }
    for key, value in default_dict.items():
        all_keys = [key]
        if type(value) == type([]):
            all_keys = [*all_keys, *value]
        for key_i in all_keys:
            if key_i in page_source:
                re[key] = 1
                break
    return re

def process_row(row):
    try:
        url = row["privacy_url"]
        if len(url) < 5:
            return row
        get_and_save_page_source_once(url)
        # 对URL执行上面的 process_url 函数
        url_result = process_url(url)
        return {**row, **url_result}
    except:
        # 在异常的情况下，你可能想要返回原始的row或其他默认值。
        return row

if __name__ == "__main__":
    # 1. 读取CSV文件
    df = pd.read_csv("d:/pro/py/pycpro1/exper/category/processed_merged_platform_data.csv")

    # 这里只保存前10行
    # df = df.head(100)

    # 2. 使用ThreadPoolExecutor并行处理
    with ThreadPoolExecutor(max_workers=8) as executor:
        results = list(executor.map(process_row, df.to_dict('records')))

    # 3. 将结果转化为DataFrame
    processed_df = pd.DataFrame(results)

    # 4. 保存结果到 compliance_readability.csv
    processed_df.to_csv("compliance_readability.csv", index=False)