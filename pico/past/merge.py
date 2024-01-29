import pandas as pd
import os

# 获取文件夹下所有csv文件
folder_path = "./gi"
csv_files = [os.path.join(folder_path, file) for file in os.listdir(folder_path) if file.endswith(".csv")]

# 读取所有csv文件，并将它们放入一个列表中
dataframes = [pd.read_csv(file) for file in csv_files]

# 使用pandas的concat函数将所有的DataFrame合并在一起
merged_df = pd.concat(dataframes, ignore_index=True)

# 如果某个csv文件中缺失了某一列，那么在合并后的DataFrame中，这一列的数据将会被填充为null
merged_df.fillna('null', inplace=True)

# 将合并后的DataFrame写入到一个新的csv文件中
merged_df.to_csv("merged.csv", index=False)
