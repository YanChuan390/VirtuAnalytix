import csv
import glob

# 找到同一目录下的所有.csv文件
csv_files = glob.glob('./*.csv')

# 遍历每个文件
for filename in csv_files:
    print(f"Reading file: {filename}")

    with open(filename, "r", encoding='utf-8') as file:
        reader = csv.reader(file)
        for row in reader:
            print(row)

    print("\n")  # 为了清楚地分隔每个文件的内容，我们在这里添加一个空行
