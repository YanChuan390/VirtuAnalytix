from langdetect import detect, detect_langs
from langdetect import DetectorFactory
import sys

def detect_language(input_str):
    # 设置随机种子以得到唯一结果
    DetectorFactory.seed = 0
    
    # 判断语言种类
    detected_lang = detect(input_str)
    
    # 获取可能的语言及其概率
    detected_langs_prob = detect_langs(input_str)
    
    return detected_lang, detected_langs_prob

def is_english(text):
    try:
        lang = detect(text)
        if lang == 'en': # 如果返回的语言代码是'en'，则表示该文本是英文
            return True
        else:
            return False
    except:
        # 在无法识别语言或发生其他错误时返回False
        return False

def test():
    # 示例用法
    input_str_chinese = '测试 what 测试 what 测试 what what 测试 what what 测试 what what 测试 what what 测试 what what 测试 what'
    input_str_other = 'Otec matka syn.'

    # 对于中文字符串
    detected_lang, detected_langs_prob = detect_language(input_str_chinese)
    print(f"Detected language: {detected_lang}")
    print(f"Detected languages with probabilities: {detected_langs_prob}")

    # 对于其他字符串
    detected_lang, detected_langs_prob = detect_language(input_str_other)
    print(f"Detected language: {detected_lang}")
    print(f"Detected languages with probabilities: {detected_langs_prob}")

sys.path.append("D:/pro/py/pycpro1/utils/content_count_and_url_lazy")
# from main import get_and_save_page_source
# from main import get_page_source_from_file
# from main import check_is_saved
# from main import get_and_save_page_source_once
# from main import delete_local_file_of_url 
# from main import generate_filename
from lazy import count_words_and_characters_in_url

# folder of txts: folder1 = d:\pro\py\pycpro1\utils\content_count_and_url_lazy\data 
# 遍历folder1中的所有txt文件
# 对于xxx.txt，逐行读取其内容，它的每一行是一个url
# 对这个url调用函数f("xxx", url)

import os
import csv
def list_txt_files(folder_path):
    txt_files = [f for f in os.listdir(folder_path) if f.endswith('.txt')]
    return txt_files

def func(filename, url):
    text = count_words_and_characters_in_url(url)[-1]
    print(filename, url)
    try:
        detected_lang, detected_langs_prob = detect_language(text)
    except:
        detected_lang, detected_langs_prob = "-1", "-1"
    output_file = "./language_analyse_result.csv"

    #在csv文件中写入三列: 分别是filename, url, detected_lang, detected_langs_prob
    with open(output_file, 'a', encoding="utf-8", newline='') as f:
        writer = csv.writer(f)
        writer.writerow([filename, url, detected_lang, detected_langs_prob])

def process_txt_file(folder_path, txt_file):
    with open(os.path.join(folder_path, txt_file), 'r', encoding="utf-8") as file:
        lines = file.readlines()
        for line in lines:
            url = line.strip()
            func(txt_file, url)

if __name__ == "__main__":
    # 文件夹路径
    folder_path = 'D:\\pro\\py\\pycpro1\\utils\\content_count_and_url_lazy\\data'
    
    # 获取文件夹中的所有TXT文件
    txt_files = list_txt_files(folder_path)
    
    # 遍历每个TXT文件并处理
    for txt_file in txt_files:
        process_txt_file(folder_path, txt_file)