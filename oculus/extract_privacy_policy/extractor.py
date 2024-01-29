import os
import pandas as pd
import re

folder_path = './../csvs/'
cnt = 0
for filename in os.listdir(folder_path):
    if filename.endswith('.csv'):
        full_file_path = os.path.join(folder_path, filename)
        df = pd.read_csv(full_file_path, encoding='utf-8')
        target_column = next((col for col in df.columns if ('privacy' in col or "Privacy" in col)), None)
        if target_column:
            elements = df[target_column].tolist()
            e = elements[0]
            with open("privacy_policys.txt", 'a', encoding="utf-8") as f:
                print(e.split()[-1], file=f)
            cnt += 1
print(cnt)