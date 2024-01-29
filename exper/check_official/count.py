import pandas as pd

# 读取csv文件
df = pd.read_csv('./official_analyse_result.csv')

# 按照第一列进行分组
groups = df.groupby(df.columns[0])

# 对于每组，统计第三列中数值大于0.5的行数占组数的比例
ratios = {}
for name, group in groups:
    total_rows = len(group)
    rows_greater_than_0_5 = len(group[group[group.columns[2]] > 0.5])
    ratio = rows_greater_than_0_5 / total_rows
    ratios[name] = ratio

print(ratios)