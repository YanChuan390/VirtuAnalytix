import os
import re

# 设置需要遍历的文件夹路径
directory = "D:\\pro\\pycpro1\\pico\\cur\\csvs"

# 定义要搜索的模式
pattern = re.compile(r"at\s+\d{4}.\d{2}.\d{2}\s+\d{2}:\d{2}:\d{2}")

def get_str_width(s):
    return sum(2 if '\u4e00' <= char <= '\u9fff' else 1 for char in s)

def get_display_str(s, width=30):
    return s.ljust(width - get_str_width(s) + len(s))

for filename in os.listdir(directory):
    if filename.endswith(".csv"):
        filepath = os.path.join(directory, filename)
        with open(filepath, 'r', encoding='utf-8') as f:
            lines = f.readlines()
            second_line_part = lines[1].split(',\"')[0] if len(lines) > 1 else ""
            match = pattern.search(''.join(lines))
            if not match:
                print(f"文件名: {get_display_str(filename[-15:-1:1], 20)} "
                      f"第二行的在[,\"]之前的部分: {get_display_str(second_line_part, 30)} "
                      f"是否存在符合模式: {get_display_str(str(bool(match)), 30)}")
