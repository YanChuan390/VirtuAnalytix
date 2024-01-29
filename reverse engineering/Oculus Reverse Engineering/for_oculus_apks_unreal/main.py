import os
import subprocess
from fileop import *
import json

def fjson(path):
    encodings = ['utf-8-sig', 'utf-8', 'latin1', 'gbk', 'gb2312']  # 可能的编码
    data = None

    for encoding in encodings:
        try:
            with open(path, 'r', encoding=encoding) as f:
                data = json.load(f)
                break
        except:
            continue

    if data is None:
        return []

    modules = data.get('Modules', [])
    module_names = [module['Name'] for module in modules]

    return module_names


def decompile_apk(apk, output_folder):
    subprocess.run(['java', '-jar', 
                    'D:/inv/apktool.jar', 
                    'd', apk, '-o', output_folder, '-f'], check=True)

def extract_from_u(path):
    with open(path, 'r') as f:
        for i in f.readlines():
            i = i.strip()

def append_to_result(s, file):
    print(s, file=open(file, 'a'))

def for_one_apk(apks_folder, apk, idx):
    work_dir = 'F:\\for_oculus_apks_unreal'

    p2 = f'{work_dir}\\temp_decompile_apk_folder_{idx}'
    p3 = f'{work_dir}\\result\\result_{idx}.txt'
    p4 = f'{work_dir}\\temp_untar_{idx}'
    p5 = f'{work_dir}\\temp_unpak_{idx}'


    pak_command = "D:\\epic_unreal\\UE_5.3\\Engine\\Binaries\\Win64\\UnrealPak.exe"
    mop = 'main.obb.png'

    apk_name = os.path.basename(apk)
    base_name = os.path.splitext(apk_name)[0]

    delete_temp_folders(os.path.abspath('.'))

    clear_file_content(p3)

    try:
        decompiled_folder = os.path.join(p2, base_name)
        decompile_apk(os.path.join(apks_folder, apk_name), decompiled_folder)

        if not find_folder(decompiled_folder, 'lib'):
            append_to_result("777123: no lib folder", p3)

        if not find_file(decompiled_folder, 'libUE4.so'):
            append_to_result("766212: no libUE4.so", p3)

        main_obb_png_path = find_file(p2, mop)

        if not main_obb_png_path:
            append_to_result("817320: No main.obb.png", p3)
            return

        untar_file(main_obb_png_path, p4)
        pak_path = find_file_ext(p4, '.pak')

        if not pak_path:
            append_to_result("736927: No .pak file", p3)
            return
        
        try:
            subprocess.run([pak_command, pak_path, '-Extract', p5])
        except:
            append_to_result("172376: error on unrealpak.exe", p3)
            return

        uplugin_file_paths = find_files_ext(p5, '.uplugin')

        if not len(uplugin_file_paths):
            append_to_result("349203: No .uplugin file", p3)
            return

        names = set()
        for uf in uplugin_file_paths:
            for i in fjson(uf):
                names.add(i)

        for i in names:
            append_to_result(i, p3)

        delete_temp_folders(os.path.abspath('.'))

    except Exception as e:
        append_to_result("918324: Error", p3)
        return

def main_ue(apks_folder):
    idxs = set()

    with open("F:\\for_oculus_apks_unity\\output.csv", 'r', encoding='utf-8') as f:
        is_first_line = True
        for i in f.readlines():
            if is_first_line:
                is_first_line = False
                continue
            if i[0] == '\"':
                i = i[1 : 10]
            idxs.add(int(i[0 : 3]))
    
    lsd = os.listdir(apks_folder)
    lsd.sort()
    print(len(lsd))

    for idx, apk in enumerate(lsd):
        if apk.endswith('.apk'):
            if idx not in idxs:
                for_one_apk(apks_folder, apk, idx)

if __name__ == '__main__':
    # print(fjson('F:/for_pico_apks_unreal/temp_unpak_folder_211/MazeFramework/Plugins/PICOXR/PICOXR.uplugin'))
    main_ue('F:\\for_oculus_apks_unity\\the_apks')
    # print(fjson('F:/for_pico_apks_unreal/temp_unpak_211/Engine/Plugins/Experimental/BackChannel/BackChannel.uplugin'))
