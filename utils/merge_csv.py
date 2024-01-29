import os
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

    # 使用pd.concat来合并所有的dataframes
    merged_df = pd.concat(df_list, axis=0, ignore_index=True, sort=False)

    merged_df = merged_df.fillna("null")
    merged_df.to_csv(os.path.join(folder_path, "all.csv"), index=False)
    return merged_df

# 调用函数
if __name__ == "__main__":
    merge_csvs("D:\pro\py\pycpro1\ocu\csvs")
