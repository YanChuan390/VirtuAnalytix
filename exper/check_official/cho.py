import sys
import os
import csv
import re
import spacy

sys.path.append("D:/pro/py/pycpro1/utils/content_count_and_url_lazy")

from lazy import get_and_save_page_source
from lazy import get_page_source_from_file
from lazy import check_is_saved
from lazy import get_and_save_page_source_once
from lazy import delete_local_file_of_url 
from lazy import generate_filename
from lazy import count_words_and_characters_in_url

ps_pp = ["https://www.playstation.com/en-sg/legal/privacy-policy/"] # ps

vv_pp = []
vv_pp.append("https://www.htc.com/us/terms/privacy/?_gl=1*tlrba9*_ga*MzM5ODY4OTAuMTY5MjkzNDM0Nw..*_ga_W8XVVB6SQQ*MTY5NDc3OTQzOS40LjAuMTY5NDc3OTQzOS42MC4wLjA.") # viveport, japan也是这个
vv_pp.append("https://www.viveport.com/cn-privacy-policy") # viveport

ms_pp = []
ms_pp.append("https://privacy.microsoft.com/en-us/privacystatement")
ms_pp.append("https://privacy.microsoft.com/zh-cn/privacystatement")
ms_pp.append("https://privacy.microsoft.com/ja-jp/privacystatement")
ms_pp.append("https://privacy.microsoft.com/zh-tw/privacystatement")

ocu_pp = ["https://www.meta.com/legal/quest/privacy-policy-for-oculus-account-users/"]

st_pp = []
st_pp.append("https://store.steampowered.com/privacy_agreement/")
st_pp.append("https://store.steampowered.com/privacy_agreement/japanese/?l=schinese")

pico_pp = []
pico_pp.append("https://www.picoxr.com/privacy/picovrappprivacy.html")
pico_pp.append("https://www.picoxr.com/terms/privacy.html")
pico_pp.append("https://www.picoxr.com/global/legal/privacy-policy")
pico_pp.append("https://www.picoxr.com/us/terms/privacy.html")


def split_sentences1(text):
    sentence_enders = re.compile('[.!?。！？]')
    sentences = sentence_enders.split(text)
    sentences = [s.strip() for s in sentences if s.strip()]
    return sentences

def calculate_plagiarism_percentage1(t1, t2):
    # 分割句子
    t1_sentences = set(split_sentences1(t1))
    t2_sentences = split_sentences1(t2)
    
    # 初始化计数器
    plagiarized_length = 0
    total_length = len(t2)
    
    # 检查每一个句子是否是抄袭的
    for sentence in t2_sentences:
        if sentence in t1_sentences:
            plagiarized_length += len(sentence)
    
    # 如果 t2 是空的，则抄袭比例为 0
    if total_length == 0:
        return 0.0
    
    # 计算抄袭比例
    plagiarism_percentage = (plagiarized_length / total_length) * 100
    
    return plagiarism_percentage

# 加载 spaCy 的多语言模型
# nlp = spacy.load("xx_ent_wiki_sm")

# def split_sentences2(text):
#     doc = nlp(text)
#     sentences = [sent.string.strip() for sent in doc.sents]
#     return sentences

# def calculate_plagiarism_percentage2(t1, t2):
#     # 分割句子并存储到集合中，以便快速查找
#     t1_sentences = set(split_sentences2(t1))
#     t2_sentences = split_sentences2(t2)

#     # 初始化变量
#     plagiarized_length = 0
#     total_length = 0

#     # 遍历 t2 中的每一个句子
#     for sentence in t2_sentences:
#         # 更新总长度
#         total_length += len(sentence)
#         # 如果这个句子也出现在 t1 中，更新抄袭长度
#         if sentence in t1_sentences:
#             plagiarized_length += len(sentence)

#     # 如果 t2 为空，返回 0
#     if total_length == 0:
#         return 0

#     # 计算抄袭百分比
#     plagiarism_percentage = (plagiarized_length / total_length) * 100
#     return plagiarism_percentage

def func(filename, url):
    try:
        print(f"current {filename} {url}")
        text = count_words_and_characters_in_url(url)[-1]
        sel = []
        if (filename == "playstation.txt"):
            sel = ps_pp
        elif (filename == "viveport.txt"):
            sel = vv_pp
        elif (filename == "microsoft.txt"):
            sel = ms_pp
        elif (filename == "oculus.txt"):
            sel = ocu_pp
        elif (filename == "steam.txt"):
            sel = st_pp
        elif (filename == "pico.txt"):
            sel = pico_pp
        else:
            return
        score = -1
        for i in sel:
            text_i = count_words_and_characters_in_url(i)[-1]
            score = max(score, calculate_plagiarism_percentage1(text_i, text))
            # score = max(score, calculate_plagiarism_percentage2(text_i, text))

        output_file = "./official_analyse_result.csv"

        #在csv文件中写入三列: 分别是filename, url, score
        with open(output_file, 'a', encoding="utf-8", newline='') as f:
            writer = csv.writer(f)
            writer.writerow([filename, url, str(score)])
    except:
        return

def list_txt_files(folder_path):
    txt_files = [f for f in os.listdir(folder_path) if f.endswith('.txt')]
    return txt_files

def process_txt_file(folder_path, txt_file):
    with open(os.path.join(folder_path, txt_file), 'r', encoding="utf-8") as file:
        lines = file.readlines()
        for line in lines:
            url = line.strip()
            func(txt_file, url)

if __name__ == "__main__":
    folder_path = 'D:\\pro\\py\\pycpro1\\utils\\content_count_and_url_lazy\\data'
    
    # 获取文件夹中的所有TXT文件
    txt_files = list_txt_files(folder_path)
    
    for txt_file in txt_files:
        process_txt_file(folder_path, txt_file)