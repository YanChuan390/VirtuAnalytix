import os
import csv
import sys
import fileop

def get_apk_names(apks_path):
    apk_names = []
    for item in os.listdir(apks_path):
        apk_abs_path = os.path.normpath(os.path.join(apks_path, item))
        apk_name = apk_abs_path.split(os.sep)[-1]
        apk_name = apk_name[0 : len(apk_name) - 4]
        apk_names.append(apk_name)
    return sorted(apk_names)



def append_to_csv(ls):
    csv_file = 'output.csv'
    with open(csv_file, 'a', newline='') as csvfile:
        writer = csv.writer(csvfile)
        if os.stat(csv_file).st_size == 0:
            writer.writerow(['APK Name', 'Eye', 'Head', 'Environment', 'Hand', 'Body', 'Face'])
        writer.writerow(ls)

def for_one_apk_count(filePath):
    filePath = os.path.normpath(filePath)
    apk_name = filePath.split(os.sep)[3]  # Use os.sep for cross-platform compatibility
    d = {"Eye": 0, "Head": 0, "Environment": 0, "Hand": 0, "Body": 0, "Face": 0}

    if not os.path.isdir(filePath):
        with open(filePath, 'r') as file:
            for line in file:
                tp = line.split(' ')[1]
                tp = tp[0 : len(tp) - 1]
                if tp in d:
                    d[tp] += 1

    append_to_csv([apk_name, d['Eye'], d['Head'], d['Environment'], d['Hand'], d['Body'], d['Face']])

def traverse_and_apply(path, target_filename, apk_names):
    for folder_path in os.listdir(path):
        folder_path = fileop.path_normalize(os.path.join(path, folder_path))

        if 'inv_folder_' in folder_path:
            file = fileop.find_file(folder_path, target_filename)
            if file:
                for_one_apk_count(os.path.join(folder_path, file))
            else:
                target_str = 'inv_folder_'
                find_pos = folder_path.find(target_str)
                idx = int(folder_path[find_pos + len(target_str): len(folder_path)]) # inv_folder_{idx}
                append_to_csv([apk_names[idx], -1, -1, -1, -1, -1, -1])

def sort_csv_by_dict_order(csv_file):
    with open(csv_file, 'r', newline='') as file:
        reader = csv.reader(file)
        header = next(reader)  # Extract the header
        sorted_data = sorted(reader, key=lambda row: tuple(row))

    with open(csv_file, 'w', newline='') as file:
        writer = csv.writer(file)
        writer.writerow(header)  # Write the header back
        writer.writerows(sorted_data)  # Write the sorted data

apks_path = 'F:\\for_oculus_apks_unity\\the_apks'
apk_names = get_apk_names(apks_path)

directory_path = 'F:\\for_oculus_apks_unity'
target_filename = 'temp12312.txt'
traverse_and_apply(directory_path, target_filename, apk_names)

sort_csv_by_dict_order('output.csv')