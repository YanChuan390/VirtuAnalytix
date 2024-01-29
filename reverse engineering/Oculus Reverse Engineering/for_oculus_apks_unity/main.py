import os
import shutil
import subprocess
import concurrent.futures
from concurrent.futures import ThreadPoolExecutor
from fileop import *

def decompile_apk(apk, output_folder):
    subprocess.run(['java', '-jar', 
                    'D:/inv/apktool.jar', 
                    'd', apk, '-o', output_folder, '-f'], check=True)

def is_mono(mono_folder):
    if os.path.isdir(mono_folder):
        # 检查 mono 文件夹中是否存在 DLL 文件
        return any(file.endswith('.dll') for file in os.listdir(mono_folder))
    return False

def extract_dlls(source_folder, dll_folder):
    if not os.path.exists(dll_folder): # 文件夹存在
        os.makedirs(dll_folder)
    for root, _, files in os.walk(source_folder): # 递归地查找所有 DLL 文件并复制它们
        for file in files:
            if file.endswith('.dll'):
                shutil.copy(os.path.join(root, file), dll_folder)

def dlls_to_csharp_process_folder(dlls_folder, folder_name, inv_folder):

    def decompile_dll(dll_path, dll_output_path):
        if not os.path.exists(dll_output_path):
            os.makedirs(dll_output_path)
        subprocess.run(['ilspycmd', '-o', dll_output_path, dll_path], check=True)

    folder_path = os.path.join(dlls_folder, folder_name)

    if os.path.isdir(folder_path):
        with ThreadPoolExecutor() as executor:
            for dll in os.listdir(folder_path):
                if dll.endswith('.dll'):
                    dll_path = os.path.join(folder_path, dll)
                    dll_output_path = os.path.join(inv_folder, folder_name, os.path.splitext(dll)[0])
                    executor.submit(decompile_dll, dll_path, dll_output_path)

def dlls_to_csharp(dlls_folder, inv_folder):
    if not os.path.exists(inv_folder):
        os.makedirs(inv_folder)
    with ThreadPoolExecutor() as executor:
        for folder_name in os.listdir(dlls_folder):
            executor.submit(dlls_to_csharp_process_folder, dlls_folder, folder_name, inv_folder)

p4 = 'd:/dumper/Il2CppDumper.exe'

def for_one_apk(apks_folder, apk, idx):
    p0 = f'temp_dlls_{idx:03d}'
    p1 = f'inv_folder_{idx:03d}'
    p2 = f'temp_decompile_apk_folder_{idx:03d}'
    p3 = f'temp_dumpresults_{idx:03d}'
    
    apk_name = os.path.basename(apk)
    base_name = os.path.splitext(apk_name)[0]
    dll_output_folder = os.path.join(p0, base_name)

    delete_temp_folders(os.path.abspath('.'))

    if count_files_and_folders(os.path.join(p1, base_name)) > 5:
        print(f'Already > 5 at {base_name}. passed')
        return

    try:
        decompile_apk__folder = p2
        decompiled_folder = os.path.join(decompile_apk__folder, base_name)
        decompile_apk(os.path.join(apks_folder, apk_name), decompiled_folder)

        mono_folder = os.path.join(decompiled_folder, 'assets', 'bin', 'Data', 'Managed')

        if is_mono(mono_folder): # mono
            print(f"{apk_name} is Monooooooooooooooo", file=open('log.txt', 'a'))
            extract_dlls(mono_folder, dll_output_folder)
        else:

            so_path = find_file(os.path.join(decompiled_folder, "lib"), "libil2cpp.so")
            dat_path = find_file(os.path.join(decompiled_folder, "assets"), "global-metadata.dat")
            output_folder = os.path.join(p3, base_name)
            
            if os.path.exists(so_path) and os.path.exists(dat_path): # il2cpp
                print(f"{apk_name} is il2cpppppppppppppppp", file=open('log.txt', 'a'))
                if not os.path.exists(output_folder):
                    os.makedirs(output_folder)
                subprocess.run([p4, so_path, dat_path, output_folder], check=True)
                extract_dlls(output_folder, dll_output_folder)
            else: # unreal
                print(f"{apk_name} is todo unrealllllllll", file=open('log.txt', 'a'))
                return

        dlls_to_csharp(p0, p1)
        delete_temp_folders(os.path.abspath('.'))

    except Exception as e:
        print(f"{apk_name} is Errorrrrrrrrrrrr", file=open('log.txt', 'a'))
        return

def main_unity(apks_folder):
    ls = os.listdir(apks_folder)
    ls.sort()
    print(len(ls))
    for idx, apk in enumerate(ls):
        if apk.endswith('.apk'):
            for_one_apk(apks_folder, apk, idx)

if __name__ == '__main__':
    main_unity('the_apks')
