import os
import shutil
import subprocess
from concurrent.futures import ThreadPoolExecutor
import zipfile

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
            return os.path.join(root, filename)
    return None

def delete_folder(folder_path):
    extended_path = f"\\\\?\\{folder_path}"
    
    if os.path.exists(extended_path):
        shutil.rmtree(extended_path)

def find_first_pak_file(directory):
    for root, dirs, files in os.walk(directory):
        for file in files:
            if file.endswith('.pak'):
                return os.path.join(root, file)
    return None
