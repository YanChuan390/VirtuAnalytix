import os
import csv
import sys

# 读取文件的所有行
def read_lines(file_path):
    lines = []
    with open(file_path, 'r', encoding='utf-8') as f:
        for i in f.readlines():
            lines.append(i.strip())
    return lines

# 对每一行的信息进行拆分，返回line_tag, content
def each_line_info(s):
    def remove_pre4_ch(s):
        l = len(s) 
        return s[4:l]
    parts = s.split('|||', 1)
    if len(parts) == 1:
        return remove_pre4_ch(parts[0]), ''
    else:
        return remove_pre4_ch(parts[0]), parts[1]

info_list = dict()
# info_list[XXX] 表示XXX对应的url的所有信息，包含它的_1, _2, ...
for folder_name in ["res", "res34"]:
    for root, dirs, files in os.walk(os.path.join(".", folder_name)):
        for file in files:
            file_path = os.path.join(".", folder_name, file)
            def file_name_without_suf(s):
                if s[-2] == "_":
                    return s[0:-2]
                return s
            real_name = file_name_without_suf(file)
            if real_name not in info_list:
                info_list[real_name] = []
            lines = read_lines(file_path)
            for i in lines:
                info_list[real_name].append(i)

def contains_japanese(text):
    for char in text:
        # 检查常用日文字符范围
        if '\u3040' <= char <= '\u309F':   # 平假名
            return True
        if '\u30A0' <= char <= '\u30FF':   # 片假名
            return True
    return False

def contains_special_char(s: str) -> bool:
    # 这只是一个非常小的繁体字示例集合，实际应用中你可能需要一个更完整的列表
    characters = set("發佈條構權間區類顯絡連äö處體業數級")
    
    for char in s:
        if char in characters:
            return True
    return False

def contains_special_substr(s: str) -> bool:
    strs = [
        "Spieler", "Festplattens", "Inhaltstyp", "Inhaltsbewertung",
        "ielbereich", "rbeit", "Letztes", "Herausgebe",
        "afikkart", "Kontakt", "Architektur", "Prozessor", "相容"
    ]
    for str_i in strs:
        if str_i in s:
            return True
    return False

column_names = set()
for k, v in info_list.items():
    t = set(v)
    for i in t:
        name = each_line_info(i)[0]
        if not contains_japanese(name) and not contains_special_char(name) and not contains_special_substr(name):
            column_names.add(name)
column_names.remove('')
column_names = list(column_names)
print(len(info_list))
print(column_names)
column_names = ['name', 'genres', '内容分级', '隐私政策', 'url', '内容分类', 'jj', '操作系统', '操作系统架构', '内容属性', 
'发布日期', '更新日期', '版本', '联系方式', 'DirectX 版本', 'OS', '内存', '发行商', 'Version', '兼容的操控方式', '最近更新', '处理器', 
'场地需求', '使用条款', '磁盘空间', 'DirectX Version', '其他说明', 'language_support', '显卡']

with open('data.csv','w', newline='', encoding='utf-8') as f:
    writer = csv.writer(f)
    writer.writerow(column_names)
    for k, v in info_list.items(): # k是文件名, v是info_list
        info = ['-'] * len(column_names)
        for column_name_index in range(len(column_names)):
            cur_tag_name = column_names[column_name_index]

            for i in set(v): # 遍历 info_list
                tag_name, tag_info = each_line_info(i)
                if tag_name == cur_tag_name:
                    if len(tag_info) >= len(info[column_name_index]):
                        info[column_name_index] = tag_info
        writer.writerow(info)
