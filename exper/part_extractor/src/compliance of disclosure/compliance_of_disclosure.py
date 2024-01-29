import csv
import os
import sys
from bs4 import BeautifulSoup
import pandas as pd
from predict_content import pre_title
from find_Title import findTitleLabel
from predict_content import get_text

sys.path.append("d:/pro/py/pycpro1/utils/content_count_and_url_lazy")
from lazy import get_and_save_page_source_once
from lazy import get_url_save_path

def list_files(directory):
    files = []
    for filename in os.listdir(directory):
        filepath = os.path.join(directory, filename)
        if os.path.isfile(filepath):
            files.append(filepath)
    return files


def all_process(path):
    try:
        soup = BeautifulSoup(open(path),features="html.parser",)
    except Exception:
        print('Formatting issues')
        return 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,"N",1, 0
    label = findTitleLabel(path)
    if label == "TitleWrong":
        print("TitleWrong")
        return 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,"N",0, 1
    title_list = soup.find_all(label)
    type, cookie, share, security, right, children, specialArea, update, how, provide, retention, useData, order = pre_title(title_list)
    # print(get_text(title_list))
    return type, cookie, share, security, right, children, specialArea, update, how, provide, retention, useData, order , 0, 0

def all_process_dict(path):
    default_dict = {
        'type': 0, 'cookie': 0, 'share': 0, 'security': 0, 'right': 0,
        'children': 0, 'specialArea': 0, 'update': 0, 'how': 0,
        'provide': 0, 'retention': 0, 'useData': 0, 'order': "N",
        'label_error': 0, 'title_error': 0
    }
    try:
        soup = BeautifulSoup(open(path), features="html.parser")
    except Exception:
        print('Formatting issues')
        default_dict['label_error'] = 1
        return default_dict

    label = findTitleLabel(path)
    if label == "TitleWrong":
        print("TitleWrong")
        default_dict['title_error'] = 1
        return default_dict
    title_list = soup.find_all(label)
    values = pre_title(title_list)
    keys = ['type', 'cookie', 'share', 'security', 'right', 'children', 'specialArea', 
            'update', 'how', 'provide', 'retention', 'useData', 'order']
    return {**dict(zip(keys, values)), **{'label_error': 0, 'title_error': 0}}

def all_process_dict_url(url):
    return all_process_dict(get_url_save_path(url))

if __name__ == "__main__":
    print(all_process("./pp_example/44684_Developer Privacy Policy.html"))

if __name__ == "__main__no":
    folder_path = "./pp_example/"
    files_in_folder = list_files(folder_path)
    for file in files_in_folder:
        if file == "./pp_example/.DS_Store":
            continue
        z = all_process(file)
        print(file, file, file, file)
        print(all_process(file))
        