import os
import subprocess
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

p4 = 'd:/dumper/Il2CppDumper.exe'

def for_one_apk(apks_folder, apk, idx):
    p2 = f'temp_decompile_apk_folder_{idx}'
    
    apk_name = os.path.basename(apk)
    base_name = os.path.splitext(apk_name)[0]

    delete_temp_folders(os.path.abspath('.'))

    try:
        decompile_apk__folder = p2
        decompiled_folder = os.path.join(decompile_apk__folder, base_name)
        decompile_apk(os.path.join(apks_folder, apk_name), decompiled_folder)

        mono_folder = os.path.join(decompiled_folder, 'assets', 'bin', 'Data', 'Managed')

        if is_mono(mono_folder): # mono
            print(f"mono {base_name}", file=open('log_count.txt', 'a'))
        else:

            so_path = find_file(os.path.join(decompiled_folder, "lib"), "libil2cpp.so")
            dat_path = find_file(os.path.join(decompiled_folder, "assets"), "global-metadata.dat")
            
            if os.path.exists(so_path) and os.path.exists(dat_path): # il2cpp
                print(f"il2cpp count {base_name}", file=open('log_count.txt', 'a'))
            else: # unreal
                print(f"todo unreal on {base_name}", file=open('log.txt', 'a'))
                return

        delete_temp_folders(os.path.abspath('.'))

    except Exception as e:
        print(f"Error on {base_name}", file=open('log.txt', 'a'))
        return

def main_unity(apks_folder):
    for idx, apk in enumerate(os.listdir(apks_folder)):
        if apk.endswith('.apk'):
            for_one_apk(apks_folder, apk, idx)

if __name__ == '__main__':
    main_unity('pico_apks')
