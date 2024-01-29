import os
import shutil
import zipfile

# 标准化路径
def path_normalize(path):
    path = os.path.abspath(path)
    path = os.path.normpath(path)
    return path

# 删除文件夹
def delete_folder(folder_path):
    extended_path = f"\\\\?\\{folder_path}"
    
    if os.path.exists(extended_path):
        shutil.rmtree(extended_path)

# 删除路径中的temp开头的文件夹
def delete_temp_folders(root_directory):
    for item in os.listdir(root_directory):
        item_path = os.path.join(root_directory, item)
        if os.path.isdir(item_path) and item.startswith('temp'):
            try:
                delete_folder(item_path)
            except Exception as e:
                print(f"无法删除 {item_path}: {e}")

# 路径中的文件和文件夹数量（非递归）
def count_files_and_folders(path):
    return len(os.listdir(path)) if os.path.exists(path) else 0

# 创建文件夹
def create_folder(path):
    if not os.path.exists(path):
        os.makedirs(path)

# 递归查找文件
def find_file(path, filename):
    for root, dirs, files in os.walk(path):
        if filename in files:
            return path_normalize(os.path.join(root, filename))
    return None

# 递归查找文件夹
def find_folder(path, dirname):
    for root, dirs, files in os.walk(path):
        if dirname in dirs:
            return path_normalize(os.path.join(root, dirname))
    return None

# 递归查找某类型文件
def find_file_ext(path, ext_name):
    for root, dirs, files in os.walk(path):
        for file in files:
            if file.endswith(ext_name):
                return path_normalize(os.path.join(root, file))
    return None

# 递归查找某类型文件的全部
def find_files_ext(path, ext_name):
    ls = []
    for root, dirs, files in os.walk(path):
        for file in files:
            if file.endswith(ext_name):
                ls.append(path_normalize(os.path.join(root, file)))
    return ls