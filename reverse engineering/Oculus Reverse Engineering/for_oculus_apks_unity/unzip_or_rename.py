import subprocess
import sys
import os
import fileop
import shutil

def un_rar_with_winrar(file_path, target_folder_path='zz', pswd='vrmoo.cn'):
    file_path = fileop.path_normalize(file_path)

    target_folder_path = fileop.path_normalize(target_folder_path)

    # 命令格式：WinRAR x -p密码 文件路径 解压目标路径
    cmd = f'"C:\\Program Files\\WinRAR\\WinRAR.exe" x -p{pswd} "{file_path}" "{target_folder_path}"'
    
    # 执行命令
    try:
        subprocess.run(cmd, check=True)
    except subprocess.CalledProcessError as e:
        print(f"解压失败：{e}")

def get_apk_count():
    x = 0
    for root, dirs, files in os.walk('the_apks'):
        for i in files:
            if i.endswith('.apk'):
                x += 1
    return x
        
def go():
    dp = 'F:/bd_dload/oculus_apks/quest'

    for idx, file in enumerate(os.listdir(dp)):
        file = os.path.join(dp, file)
        ji1 = get_apk_count()

        z = fileop.path_normalize('./zz')
        fileop.delete_folder(z)
        fileop.create_folder(z)

        try:
            un_rar_with_winrar(file, target_folder_path=z)
        except:
            print(f'un_tar_err on {file}', file=open('log.txt', 'a'))
            continue

        chong = 0

        for root, dirs, files in os.walk(z):
            for i in files:
                i = os.path.join(root, i)
                if i.endswith('.apk'):
                    print("moving", i)
                    try:
                        shutil.move(i, 'the_apks')
                    except Exception as e:
                        if 'already exists' in str(e):
                            chong = 1
                            continue
                        else:
                            print(e)
                            sys.exit(0)

        ji2 = get_apk_count()

        if chong or ji2 >= ji1 + 1:
            os.remove(file)
        elif fileop.find_file_ext('zz', 'exe'):
            os.remove(file)
            print("EXEEEEEEEEEEEE", file)
        else:
            print(file)
            break


import os
import re

def replace_space_with_underscore(folder_path):
    ls = os.listdir(folder_path)
    ls.sort()
    # 遍历文件夹中的所有文件和文件夹
    for idx, filename in enumerate(ls):
        new_filename = f'{idx:03d}_{filename}'

        # 获取原文件和新文件的完整路径
        original_file = os.path.join(folder_path, filename)
        new_file = os.path.join(folder_path, new_filename)

        try: # 重命名文件
            os.rename(original_file, new_file)
            print(f"Renamed '{filename}' to '{new_filename}'")
        except:
            continue

folder_path = 'F:/for_oculus_apks_unity/the_apks'
replace_space_with_underscore(folder_path)
