import csv
import re

with open("o1/old_result1.txt", "r", encoding='utf-8') as file:
    content = file.readlines()
    for index, line in enumerate(content):
        line = line.strip()  # 删除前后的空白字符
        keys = re.findall(r"'[^']*': ", line)  # 找到所有的关键词
        values = re.split(r"'[^']*': ", line)[1:]  # 根据关键词来切分数据
        if len(keys) != len(values):
            with open("err.txt", "a", encoding='utf-8') as err_file:
                err_file.write(line + "\n")
            continue
        result_dict = {}

        print(f'keys: {type(keys)}')
        for i in keys:
            print(i)

        print(f'values: {type(values)}')
        for i in values:
            print(i)

        with open(f'./gi/game_info1_{index+1}.csv', 'w', newline='', encoding='utf-8') as file:
            writer = csv.writer(file)
            writer.writerow(keys)
            writer.writerow(values)

with open("o1/old_result1_.txt", "r", encoding='utf-8') as file:
    content = file.readlines()
    for index, line in enumerate(content):
        line = line.strip()  # 删除前后的空白字符
        keys = re.findall(r"'[^']*': ", line)  # 找到所有的关键词
        values = re.split(r"'[^']*': ", line)[1:]  # 根据关键词来切分数据
        if len(keys) != len(values):
            with open("err.txt", "a", encoding='utf-8') as err_file:
                err_file.write(line + "\n")
            continue
        result_dict = {}

        print(f'keys: {type(keys)}')
        for i in keys:
            print(i)

        print(f'values: {type(values)}')
        for i in values:
            print(i)

        with open(f'./gi/game_info2_{index+1}.csv', 'w', newline='', encoding='utf-8') as file:
            writer = csv.writer(file)
            writer.writerow(keys)
            writer.writerow(values)

