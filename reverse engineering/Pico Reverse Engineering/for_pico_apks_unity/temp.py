import os
import shutil

for i in os.listdir('.'):
    if i.startswith('inv_folder'):
        pi = os.path.join('.', i)
        for apk_folder_path in os.listdir(pi):
            to_del = []
            not_del = []
            for dll_folder_path in os.listdir(os.path.join(pi, apk_folder_path)):
                if 'Assem' not in dll_folder_path:
                    to_del.append(os.path.join(pi, apk_folder_path, dll_folder_path))
                else:
                    not_del.append(os.path.join(pi, apk_folder_path, dll_folder_path))
            for i in to_del:
                if os.path.isdir(i):
                    shutil.rmtree(os.path.abspath(i))
