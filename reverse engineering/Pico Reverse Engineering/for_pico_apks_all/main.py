import re
import os
import sys
import math
from fileop import path_normalize
import csv

def clean_string(ss):
    s = ss
    # 只保留汉字和英文字母，并将英文字母转换为小写
    cleaned_s = ''.join(re.findall(r'[\u4e00-\u9fff]|[a-zA-Z]|[0-9]', s)).lower()
    return cleaned_s

def count_chars(s):
    # 计算汉字和英文字母的数量
    chinese_chars = re.findall(r'[\u4e00-\u9fff]', s)
    english_chars = re.findall(r'[a-zA-Z]', s)
    return len(chinese_chars), len(english_chars)

def find_substring(s1, _s2): # s1是str，s2是list<str>
    s2 = [0] * len(_s2)
    for i in range(len(s2)):
        s2[i] = clean_string(_s2[i])
    s1 = clean_string(s1)
    # 枚举所有可能的s1的子串，优先枚举长度较长的
    for length in range(len(s1), 3, -1):  # 长度至少为4
        for start in range(0, len(s1) - length + 1):
            s1_substr = s1[start:start + length]
            c_ch, c_en = count_chars(s1_substr)
            if c_ch >= 2 or c_en >= 3 or (c_ch + c_en) >= 4:
                # 在s2中搜索s1_substr
                for i, s2_str in enumerate(s2):
                    if s2_str.find(s1_substr) != -1:
                        return i, s1_substr
    return -1, "" 

def test_str1_list_str2_find():
    s1 = "8948934蝙蝠f4092490"
    s2 = ["蝙蝠；F 4"]
    result = find_substring(s1, s2)
    print(result)

def get_apk_name_list():
    pico_apks_path = 'F:\\for_pico_apks\\pico_apks'
    re = []
    for entry in os.listdir(pico_apks_path):
        e = path_normalize(entry)
        apk_name_with_ext = e.split(os.sep)[-1]
        apk_ord = apk_name_with_ext[0 : 3]
        apk_name = apk_name_with_ext[4 : len(apk_name_with_ext)]
        apk_n = apk_name[0 : len(apk_name) - 4]
        re.append([apk_ord, apk_n])

    re.sort()
    assert len(re) == 451
    apk_name_list = [''] * 451

    for i in range(0, 451):
        apk_name_list[i] = re[i][1]
    return apk_name_list

row_names = ['Ord', 'Apk_Name', 'Matched_Apk_Name', 'Type', 'Url']
    
anl = get_apk_name_list()


tp = ['NUL'] * 451

bio_unity = [["NUL" for _ in range(6)]] * 451
with open('output.csv', newline='', encoding='utf-8') as f:
    content = list(csv.reader(f))

    for i in range(1, len(content[0])):
        content[0][i] = f'Unity_{content[0][i]}_Count'
        row_names.append(content[0][i])

    for i in range(1, len(content)):
        row = content[i]
        idx = row[0][0 : 3]
        idx = int(idx)
        tp[idx] = "Unity"
        bio_unity[idx] = row[1 : len(row)]


row_names.append('Unreal_Module_Names')
bio_unreal = ['NUL'] * 451
for res in os.listdir('result'):
    u = res.split('.')[0]
    u = u[7 : len(u)]
    u = int(u)
    tp[u] = "Unreal"
    bio_unreal[u] = open(os.path.join('result', res), 'r').read()


mat = [''] * 451
urls = ['NUL'] * 451
with open('merged.csv', newline='', encoding='utf-8') as f:
    content = list(csv.reader(f))
    j = 0
    names = content[0]
    for idx, name in enumerate(names):
        if name == 'url':
            j = idx
    apk_names = []
    for i in content:
        apk_names.append(i[0])

    for i in range(len(anl)):
        idx, s2_s = find_substring(anl[i], apk_names)
        mat[i] = apk_names[idx]
        url = content[idx][j]
        if len(url) > 4:
            urls[i] = url
    
print(row_names)

big = []
big.append(row_names)
for i in range(451):
    w = []
    w.append(str(i))
    w.append(anl[i])
    w.append(mat[i])
    w.append(tp[i])
    w.append(urls[i])
    for j in range(6):
        w.append(bio_unity[i][j])
    w.append(bio_unreal[i])
    big.append(w)


with open('hh.csv', 'w', newline='', encoding='utf-8') as f:
    wtr = csv.writer(f)
    
    for i in big:
        wtr.writerow(i)

def delete_unity():
    pico_apks_path = 'F:\\for_pico_apks\\pico_apks'
    to_remove = []
    for entry in os.listdir(pico_apks_path):
        e = path_normalize(entry)
        apk_name_with_ext = e.split(os.sep)[-1]
        apk_ord = apk_name_with_ext[0 : 3]
        apk_ord = int(apk_ord)
        if big[apk_ord][3] == 'Unity':
            to_remove.append(entry)
    for i in to_remove:
        p = os.path.join(pico_apks_path, i)
        os.remove(p)


delete_unity()
