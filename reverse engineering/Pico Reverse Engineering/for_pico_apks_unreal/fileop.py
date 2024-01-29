import os
import shutil
import zipfile

def path_normalize(path):
    path = os.path.abspath(path)
    path = os.path.normpath(path)
    return path

def delete_folder(folder_path):
    folder_path = os.path.abspath(folder_path)
    extended_path = f"\\\\?\\{folder_path}"
    if os.path.exists(extended_path):
        shutil.rmtree(extended_path)

def delete_temp_folders(directory):
    for item in os.listdir(directory):
        item_path = os.path.join(directory, item)
        if os.path.isdir(item_path) and item.startswith('temp'):
            try:
                delete_folder(item_path)
            except Exception as e:
                print(f"无法删除 {item_path}: {e}")

def count_files_and_folders(path):
    return len(os.listdir(path)) if os.path.exists(path) else 0

def create_folder(path):
    if not os.path.exists(path):
        os.makedirs(path)

def find_file(path, filename):
    for root, dirs, files in os.walk(path):
        if filename in files:
            return path_normalize(os.path.join(root, filename))
    return None

def find_folder(path, dirname):
    for root, dirs, files in os.walk(path):
        if dirname in dirs:
            return path_normalize(os.path.join(root, dirname))
    return None

def find_file_ext(path, ext_name):
    for root, dirs, files in os.walk(path):
        for file in files:
            if file.endswith(ext_name):
                return path_normalize(os.path.join(root, file))
    return None

def find_files_ext(path, ext_name):
    ls = []
    for root, dirs, files in os.walk(path):
        for file in files:
            if file.endswith(ext_name):
                ls.append(path_normalize(os.path.join(root, file)))
    return ls

def delete_folder(folder_path):
    extended_path = f"\\\\?\\{folder_path}"
    
    if os.path.exists(extended_path):
        shutil.rmtree(extended_path)

def find_first_pak_file(directory):
    for root, dirs, files in os.walk(directory):
        for file in files:
            if file.endswith('.pak'):
                return path_normalize(os.path.join(root, file))
    return None

def untar_file(tar_file_path, output_folder_path, new_extension='.zip'):
    if not os.path.exists(output_folder_path):
        os.makedirs(output_folder_path)
    
    base = os.path.splitext(tar_file_path)[0] # 去掉后缀.png
    base = os.path.splitext(base)[0] # 去掉后缀.obb

    new_file_path = base + new_extension

    # 重命名（复制）文件
    shutil.copy(tar_file_path, new_file_path)
    
    with zipfile.ZipFile(new_file_path, 'r') as zip_ref:
        zip_ref.extractall(output_folder_path)

# 以写入模式打开文件，自动清空文件内容
def clear_file_content(file_path):
    with open(file_path, 'w'):
        pass  # 不需要做任何操作，打开文件即清空内容

# mop = find_file('temp_decompile_apk_folder_63', 'main.obb.png')
# untar_file(mop, 'temp_folder_63')
