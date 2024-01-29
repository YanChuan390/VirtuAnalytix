import pandas as pd
import sys
from url_language_mapping import get_url_language_list
from voc_all import get_str_code_dict

def for_heatmap():
    csv_data = [] # name.txt pp_url lan

    if 1: # get csv_data
        df = pd.read_csv('./language_analyse_result.csv')
        df = df[df.iloc[:, 0] != 'steam.txt']
        for index, row in df.iterrows():
            w = [row[col] for col in df.columns]
            w = w[0 : 3]
            w[2] = w[2][0 : 2]
            if w[2] != "-1":
                csv_data.append(w)
        df = None # clear
    
    print(csv_data[0 : 10])
    
    if 1: # get csv_data[3]
        mapping_list = get_url_language_list() # url, language_text
        str_code_dict = get_str_code_dict() # language_text, language_code

        csv_data_temp = []

        for name, pp_url, lan in csv_data:
            have = False
            for i in mapping_list:
                if pp_url not in i:
                    continue
                for language_text, language_code in str_code_dict.items():
                    if language_code[0 : 2] == lan[0 : 2] and language_text in i:
                        have = True
            csv_data_temp.append([name, pp_url, lan, have])
        
        csv_data = csv_data_temp
        csv_data_temp = None # clear

    all_language = dict()
    all_platform = []

    for w in csv_data:
        lan_name = w[2] # such as: 'en'

        if lan_name not in all_language:
            all_language[lan_name] = 0

        all_language[lan_name] = all_language[lan_name] + 1 # such as: all_language['en'] += 1

        pla_name = w[0];
        if len(all_platform) == 0 or pla_name != all_platform[-1]:
            all_platform.append(pla_name) # such as: append('steam.txt')

    print(all_platform)
    print(all_language)

    all_language_ordered = list(all_language.keys())
    all_language_ordered.sort(key=lambda x: all_language[x], reverse=True) # sort by all_language['en'] = 1830

    cnt = [] # cnt[i][j]代表第i个平台上的第j种语言的数量
    cnt_true = []

    if 1: # get cnt and cnt_true
        for i in range(len(all_platform)):
            cnt.append([0] * len(all_language_ordered))
            cnt_true.append([0] * len(all_language_ordered))

        for i in range(len(all_platform)):
            for j in range(len(all_language_ordered)):
                for w in csv_data:
                    if w[0] == all_platform[i] and w[2] == all_language_ordered[j]:
                        cnt[i][j] += 1 # fill cnt[i][j]
                        cnt_true[i][j] += (1 if w[3] else 0)

        for i in range(len(cnt)):
            for j in range(8, len(cnt[i])): # other语言
                cnt[i][7] += cnt[i][j]
                cnt_true[i][7] += cnt_true[i][j]
            cnt[i] = cnt[i][:8]
            cnt_true[i] = cnt_true[i][:8]

    all_language_ordered = all_language_ordered[:7]
    all_language_ordered.append("other")

    row_labels = list(all_platform)
    col_labels = list(all_language_ordered)

    return row_labels, col_labels, cnt, cnt_true

