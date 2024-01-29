import os
import hashlib
from selenium import webdriver
import time, csv
import concurrent.futures

data_directory = './data'
result_file = 'result.csv'

from bs4 import BeautifulSoup

# 根据local.page_source，使用soup获取字符数量和单词数量
def count_words_and_characters_in_url(url, directory=dps):
    # 从文件中读取页面源代码
    page_source = get_and_save_page_source_once(url, directory)

    if page_source is None:
        delete_local_file_of_url(url, directory)
        page_source = get_and_save_page_source_once(url, directory)
    
    if page_source is None:
        return "-1", "-1", "-1"

    # 使用 BeautifulSoup 解析页面源代码
    soup = BeautifulSoup(page_source, 'html.parser')

    text = ""
    for tag in soup.find_all(True):
        # 如果标签不是要忽略的标签
        if tag.name in ["p", "span", "h", "h1", "h2", "h3",
                        "em", "small", "s", "q", "u", "mark"
                         "h4", "h5", "h6", "tl", "strong"
                         "div", "li"
                         ]:
            text += tag.text + " "

    char_count = len(text.replace(" ", ""))
    # 统计单词数量
    word_count = len(text.split())

    return word_count, char_count, text


if __name__ == "__main__x": # 获取某文件夹下所有txt中的privacy_policy_url的page_source
    urls_to_process = []
    for filename in os.listdir(data_directory):
        if filename.endswith('.txt'):
            file_path = os.path.join(data_directory, filename)
            with open(file_path, 'r', encoding='utf-8') as txt_file:
                lines = txt_file.readlines()
                for i, line in enumerate(lines):
                    urls_to_process.append(line)
    # 使用 ThreadPoolExecutor 进行并行处理
    with concurrent.futures.ThreadPoolExecutor(max_workers=5) as executor:
        executor.map(get_and_save_page_source, urls_to_process)


if __name__ == "__main__y": # 对一些privacy_policy_url调用character&word count
    # url = "https://aguroshou0413.wixsite.com/mysite"
    # url = "http://www.greykernel.com/"
    # url = "https://goalienator.com/privacy-policy/"
    # url = "https://visitationsvr.com/privacy/"
    # url = "http://www.neuston.io/volleyball-fever-privacy-policy/"
    # url = "https://vedev.cc/cosmicflow-privacy/" # 很少
    # url = "http://www.neuston.io/volleyball-fever-privacy-policy/" # 少
    url = "https://www.baidu.com"
    url = "https://toymonsters.mdfx.cz/privacyPolicy.html"
    url = "https://www.krgames.it/en/privacy-policy"
    url = "https://www.jianshu.com/p/cf052232b7b5"
    url = "https://privacy.microsoft.com/en-us/privacystatement"
    url = "https://taqtile.com/privacy/"
    url = "https://privacy.microsoft.com/zh-CN/privacystatement"

    word_count, char_count = count_words_and_characters_in_url(url)
    if word_count is not None and char_count is not None:
        print(f"The page at {url} has {word_count} words and {char_count} characters.")

def process_url(args): # 对每个url调用count_words_and_characters_in_url
    try:
        i, line, filename = args
        line = line.strip()
        if not line:
            return None
        
        with open(result_file, 'r', encoding='utf-8') as f:
            if any(line in l for l in f):
                return None
        
        word_count, char_count, text = count_words_and_characters_in_url(line)
        
        if word_count != -1 and char_count != -1:
            text = text.replace('\n', ' ')
            return [filename, i, line, word_count, char_count, text]
        
        return None
    except:
        return None

def main():
    # 打开结果CSV文件进行写入
    with open(result_file, 'a+', newline='', encoding='utf-8') as res_file:
        csv_writer = csv.writer(res_file)
        # 如果需要，可以写入标题行
        csv_writer.writerow(['Filename', 'Index', 'URL', 'Word_Count', 'Char_Count', 'Text'])
        
        urls_to_process = []

        # 遍历./data文件夹下的所有文件
        for filename in os.listdir(data_directory):
            if filename.endswith('.txt'):
                file_path = os.path.join(data_directory, filename)
                with open(file_path, 'r', encoding='utf-8') as txt_file:
                    lines = txt_file.readlines()
                    for i, line in enumerate(lines):
                        urls_to_process.append((i, line, filename))
        
        # urls_to_process = urls_to_process[0:30]

        # 使用 ThreadPoolExecutor 进行并行处理
        with concurrent.futures.ThreadPoolExecutor(max_workers=5) as executor:
            for result in executor.map(process_url, urls_to_process):
                if result:
                    csv_writer.writerow(result)

if __name__ == "__main__":
    main()
