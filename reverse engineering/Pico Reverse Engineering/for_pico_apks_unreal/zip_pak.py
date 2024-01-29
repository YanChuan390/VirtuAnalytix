import subprocess
from fileop import *

pak_command = "D:\\epic_unreal\\UE_5.3\\Engine\\Binaries\\Win64\\UnrealPak.exe"

num = 191

mop = find_file(f'temp_decompile_apk_folder_{num}', 'main.obb.png')
untar_file(mop, f'temp_folder_{num}')
pak_path = find_file_ext(f'temp_folder_{num}', '.pak')

print("PAK_PATH", pak_path)

output_folder_path = f"F:\\for_pico_apks_ue\\temp_unpak_folder_{num}"

# 构建完整的命令
cmd = [pak_command, pak_path, '-Extract', output_folder_path]

subprocess.run(cmd)