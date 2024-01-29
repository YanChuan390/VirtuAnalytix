# 对一个文件夹内所有的csv文件进行合并
import os
import csv
import pandas as pd

def merge_csvs(folder_path):
    file_names = os.listdir(folder_path)
    df_list = []

    # 对file_names中的每一个文件名进行遍历
    for file_name in file_names:
        if file_name.endswith('.csv'):
            file_path = os.path.join(folder_path, file_name)
            df = pd.read_csv(file_path)
            df_list.append(df)

    # 初始化一个空集合，用于存储所有CSV文件的列名
    all_cols = set()
    for df in df_list:
        all_cols = all_cols | set(df.columns)

    merged_df = pd.DataFrame(columns=all_cols)
    for df in df_list:
        merged_df = merged_df.merge(df, how='outer')

    merged_df = merged_df.fillna("null")
    merged_df.to_csv(os.path.join(folder_path, "all.csv"), index=False)
    return merged_df

# merge_csvs("./../csvs/")
