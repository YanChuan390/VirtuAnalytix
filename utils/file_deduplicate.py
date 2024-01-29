import os
from collections import OrderedDict


# 对文件去除重复行（保持原来的行顺序）
def deduplicate_file_lines(file_path):
    try:
        with open(file_path, 'r', encoding="utf-8") as f:
            lines = f.readlines()

        unique_lines = list(OrderedDict.fromkeys(lines))

        with open(file_path, 'w', encoding="utf-8") as f:
            f.writelines(unique_lines)
    except Exception as e:
        print(f"Error processing {file_path}. Error: {e}")

# 对文件夹内所有的txt文件去除重复行（保持原来的行顺序）
def deduplicate_files_in_directory(directory_path):
    for root, dirs, files in os.walk(directory_path):
        for file in files:
            if file.endswith('.txt'):
                full_path = os.path.join(root, file)
                deduplicate_file_lines(full_path)

# if __name__ == "__main__":
#     deduplicate_files_in_directory('d:/pro/py/pycpro1/utils/type1_res')

def should_delete_file(file_path):
    try:
        with open(file_path, 'r', encoding="utf-8") as f:
            lines = f.readlines()

        # 检查所有行是否都是以"origin..."开头的
        for line in lines:
            if not line.startswith("origin"):
                return False  # 如果有任何一行不是以"origin"开头的，则不删除该文件
        return True  # 所有行都是以"origin"开头的，返回True表示需要删除此文件
    except Exception as e:
        print(f"Error reading {file_path}. Error: {e}")
        return False  # 出错时默认不删除文件

def delete_specific_files_in_directory(directory_path):
    for root, dirs, files in os.walk(directory_path):
        for file in files:
            if file.endswith('.txt'):
                full_path = os.path.join(root, file)
                if should_delete_file(full_path):
                    try:
                        os.remove(full_path)
                        print(f"Deleted: {full_path}")
                    except Exception as e:
                        print(f"Error deleting {full_path}. Error: {e}")

delete_specific_files_in_directory('d:/pro/py/pycpro1/ms/type2_res')