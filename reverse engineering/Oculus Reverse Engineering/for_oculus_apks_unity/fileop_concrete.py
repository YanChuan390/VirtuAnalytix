import os
import shutil
import zipfile
from fileop import path_normalize

# 递归查找一个.pak文件
def find_first_pak_file(directory):
    for root, dirs, files in os.walk(directory):
        for file in files:
            if file.endswith('.pak'):
                return path_normalize(os.path.join(root, file))
    return None

# 解压main.obb.png文件
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

# mop = find_file('temp_decompile_apk_folder_63', 'main.obb.png')
# untar_file(mop, 'temp_folder_63')

# 以写入模式打开文件，自动清空文件内容
def clear_file_content(file_path):
    with open(file_path, 'w'):
        pass  # 不需要做任何操作，打开文件即清空内容
