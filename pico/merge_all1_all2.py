import sys
import pandas as pd
import re

# 读取两个csv文件
df_a = pd.read_csv('./cur/csvs/all.csv')
df_b = pd.read_csv('./cur_without_age/csvs/all.csv')

# 获取两个数据框的所有列名的并集
all_columns = set(df_a.columns) | set(df_b.columns)

# 获取两个数据框中'name'列的值的并集
all_names = set(df_a['name']) | set(df_b['name'])

# 创建一个空的DataFrame用于保存合并后的结果
merged_df = pd.DataFrame(columns=all_columns)

# 辅助函数：处理null值
def handle_null(value):
    return '' if value == 'null' or pd.isnull(value) else value

# 合并行的辅助函数
def merge_two_rows(row1, row2):
    merged_row = {}
    for col in all_columns:
        val_1 = handle_null(row1.get(col, ''))
        val_2 = handle_null(row2.get(col, ''))
        
        # 根据值的长度决定保留哪个值
        merged_row[col] = val_1 if len(val_1) > len(val_2) else val_2
    return merged_row

# 遍历所有'name'的值
for name in all_names:
    rows_a = df_a[df_a['name'] == name]
    rows_b = df_b[df_b['name'] == name]
    
    # 初始化每个name对应的合并行为一个空白行
    merged_row = {col: '' for col in all_columns}
    for _, row in rows_a.iterrows():
        merged_row = merge_two_rows(merged_row, row)
    for _, row in rows_b.iterrows():
        merged_row = merge_two_rows(merged_row, row)
    
    merged_df = merged_df.append(merged_row, ignore_index=True)

def simplify(url):
    # 查找模式 "at YYYY.MM.DD HH:MM:SS"
    match = re.search(r'at \d{4}\.\d{2}\.\d{2} \d{2}:\d{2}:\d{2}', url)
    if match:
        # 找到模式的开始位置
        start_pos = match.start()
        # 向前查找直到遇到双引号
        for i in range(start_pos, -1, -1):
            if url[i] == '"':
                return url[i+1:start_pos].strip()
    # 如果没有找到匹配模式或双引号，返回原始URL
    return url

merged_df['url'] = merged_df['url'].apply(simplify)
# 对每个单元格，如果其内容含有换行符，则将其替换为空格
merged_df = merged_df.applymap(lambda x: x.replace('\n', ' ') if isinstance(x, str) else x)

# 保存合并后的数据框到新的csv文件
merged_df.to_csv('merged.csv', index=False)
