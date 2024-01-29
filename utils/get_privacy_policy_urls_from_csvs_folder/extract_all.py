import os
import csv


# 获取某个文件夹下所有csv文件中的privacy_policy_url,
def extract_urls_from_csv(directory):
    urls = set()  # 创建一个集合来存储URLs

    # 递归遍历指定目录下的所有文件
    for dirpath, _, filenames in os.walk(directory):
        for filename in filenames:
            if filename.endswith('.csv'):  # 检查文件是否是CSV文件
                filepath = os.path.join(dirpath, filename)
                
                # 读取CSV文件的内容
                with open(filepath, 'r', encoding="utf-8") as file:
                    try:
                        reader = csv.reader(file)
                        for row in reader:
                            for cell in row:
                                # 使用空格、逗号和点来分割每个单元格的内容
                                parts = cell.split(' ') + cell.split(',')
                                for part in parts:
                                    if part.startswith('http') and "privacy" in parts:
                                        urls.add(part)
                    except:
                        continue

    return urls

directory_to_search = "d:/pro/py/pycpro1"
resulting_urls = extract_urls_from_csv(directory_to_search)

with open("./extract_all.txt", "w", encoding="utf-8") as f:
    for url in resulting_urls:
        f.write(url + "\n")