import csv
from collections import defaultdict

def count_tuples_from_csv(filename):
    # 使用defaultdict来简化计数
    tuple_count = defaultdict(int)

    with open(filename, 'r', newline='', encoding='utf-8') as csvfile:
        reader = csv.reader(csvfile)

        for row in reader:
            # 提取第一列和第六列的值
            col1 = row[0]
            col6 = row[5]
            
            # 将值组成元祖并更新计数
            tuple_count[(col1, col6)] += 1

    return tuple_count

filename = 'd:/pro/py/pycpro1/exper/name_age/updated_processed_merged_platform_data_bio.csv'  # 用你的CSV文件名替换
result = count_tuples_from_csv(filename)

# 打印结果
for tuple_val, count in result.items():
    print(f"{tuple_val}: {count}")

'''
microsoft
148 / (148 + 324) =
0.3135593220338983
('microsoft', 'True'): 148
('microsoft', 'False'): 324

oculus
1815 / (1815 + 400 + 15) =
0.8139013452914798
('oculus', 'True'): 1815
('oculus', 'False'): 400
('oculus', ''): 15

pico
181 / (181 + 124 + 139) =
0.40765765765765766
('pico', 'True'): 181
('pico', 'False'): 124
('pico', ''): 139

playstation
22 / (22 + 11 + 267) = 
0.07333333333333333
('playstation', 'True'): 22
('playstation', 'False'): 11
('playstation', ''): 267

viveport
297 / (287 + 2804 + 1) = 
0.09605433376455369
('viveport', 'True'): 297
('viveport', 'False'): 2804
('viveport', ''): 1
'''

'''
('microsoft', ''): 261
('microsoft', 'False'): 115
('microsoft', 'True'): 96

('oculus', 'True'): 965
('oculus', 'False'): 1237
('oculus', ''): 28

('pico', 'True'): 123
('pico', ''): 139
('pico', 'False'): 182

('playstation', 'True'): 25
('playstation', ''): 267
('playstation', 'False'): 8

('viveport', ''): 2678
('viveport', 'True'): 226
('viveport', 'False'): 198
'''