import os

# 读取txt文件并存储每一行到set中
lines_set = set()
with open("D:\\pro\\pycpro1\\pico\\cur\\names.txt", 'r', encoding='utf-8') as txt_file:
    for line in txt_file:
        lines_set.add(line.strip())

# 设置需要遍历的文件夹路径
directory = "D:\\pro\\pycpro1\\pico\\cur\\csvs"

# 需要删除的文件列表
files_to_delete = []

# 遍历文件夹中的每个csv文件
for filename in os.listdir(directory):
    if filename.endswith(".csv"):
        filepath = os.path.join(directory, filename)
        with open(filepath, 'r', encoding='utf-8') as f:
            lines = f.readlines()
            file_content = ''.join(lines)
            # 检查是否存在任何一个linei
            if not any(line in file_content for line in lines_set):
                # 如果不存在，显示文件内容并询问是否要删除
                print(f"文件 '{filename}' 的内容为:\n{file_content}")
                print(f"文件 '{filename}' 的第二行前10个字符为: {lines[1][:10]}")
                print(f"文件 '{filename}' 的最后一行最后10个字符为: {lines[-1][-10:]}")
                confirm = input("是否要删除这个文件? (y/n) ")
                if confirm.lower() == 'y':
                    # 如果确认，添加到待删除文件列表
                    files_to_delete.append(filepath)

# 输出所有待删除的文件名
print("以下文件将被删除:")
for file in files_to_delete:
    print(file)

# 确认删除
confirm = input("确定要删除这些文件吗? (y/n) ")
if confirm.lower() == 'y':
    # 删除所有待删除的文件
    for file in files_to_delete:
        os.remove(file)
    print("文件删除成功.")
else:
    print("操作已取消.")

# 是否要删除这个文件? (y/n) >? y
# 以下文件将被删除:
# D:\pro\pycpro1\pico\cur\csvs\result_csv(2023-07-20_01_54_05)_9209013.csv
# D:\pro\pycpro1\pico\cur\csvs\result_csv(2023-07-20_02_15_01)_1617750.csv
# D:\pro\pycpro1\pico\cur\csvs\result_csv(2023-07-20_03_18_42)_1820595.csv
# D:\pro\pycpro1\pico\cur\csvs\result_csv(2023-07-20_03_37_37)_3694446.csv
# D:\pro\pycpro1\pico\cur\csvs\result_csv(2023-07-20_06_22_36)_7019548.csv
# D:\pro\pycpro1\pico\cur\csvs\result_csv(2023-07-24_03_16_26)_7909671.csv
# D:\pro\pycpro1\pico\cur\csvs\result_csv(2023-07-24_03_57_38)_5404846.csv
# D:\pro\pycpro1\pico\cur\csvs\result_csv(2023-07-24_04_22_06)_8673069.csv
# D:\pro\pycpro1\pico\cur\csvs\result_csv(2023-07-24_05_37_36)_3025948.csv
# D:\pro\pycpro1\pico\cur\csvs\result_csv(2023-07-24_07_55_18)_806060.csv
# D:\pro\pycpro1\pico\cur\csvs\result_csv(2023-07-24_08_10_49)_6995705.csv
# 确定要删除这些文件吗? (y/n) >? y
# 文件删除成功.



# 重播 魔法花园