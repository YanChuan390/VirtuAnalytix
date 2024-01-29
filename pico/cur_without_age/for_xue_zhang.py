import os
import pandas as pd
import re

def pi(text):
    pattern = r"(http.*?)at"
    matches = re.findall(pattern, text)
    return matches  # 返回匹配到的所有项

all_elements = []
folder_path = './csvs/'
cnt = 0
for filename in os.listdir(folder_path):
    if filename.endswith('.csv'):
        full_file_path = os.path.join(folder_path, filename)
        df = pd.read_csv(full_file_path, encoding='utf-8')
        target_column = next((col for col in df.columns if 'url' in col), None)
        if target_column:
            elements = df[target_column].tolist()
            e = elements[0]
            all_elements.extend(pi(e))
            with open("xue.txt", 'a', encoding="utf-8") as f:
                print(pi(e)[0], file=f)
            cnt += 1
