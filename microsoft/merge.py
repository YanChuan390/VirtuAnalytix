import os
import glob
import csv

folder_path1 = "./type1_result"
folder_path2 = "./type2_result"

def line_split(s):
    parts = s.split(":", 1)
    if len(parts) == 2:
        return parts[0].strip(), parts[1].strip()
    else:
        return s, ""

tag_names = set()

for folder_path in [folder_path1, folder_path2]:
    for txt_file in glob.glob(os.path.join(folder_path, '*.txt')):
        with open(txt_file, 'r', encoding='utf-8') as file:
            for line in file:
                tag_name, content = line_split(line.strip())
                tag_names.add(tag_name)

# tag_names.add("publish_info")
# tag_names.add("support language")
tag_names.remove("")

print(tag_names)

ls =  ['name', 'Age_rating', 'age_info', 'category', 'Category', 'privacy_policy', 'Report_this_product', 'Developed_by', 'Published_by', 
'Additional_terms', 'In-app_purchases', 'support language', 'Language_supported', 
'Please note', 'Copyright', 'Installation', 'Approximate_size', 'This_app_can', 'Seizure_warnings', 'Publisher_Info', 
'Release_date', 'publish_info', 'Accessibility', 'origin_url', 'description']

tag_names = ls
tag_len = len(tag_names)

with open('data.csv', 'w', newline='', encoding="utf-8") as csvfile:
    writer = csv.writer(csvfile)
    writer.writerow(tag_names)

    for folder_path in [folder_path1, folder_path2]:
        for txt_file in glob.glob(os.path.join(folder_path, '*.txt')):
            with open(txt_file, 'r', encoding="utf-8") as file:
                file_lines = file.readlines()
                cur = ["."] * tag_len 
                for i in range(tag_len):
                    for line in file_lines:
                        tag_name, content = line_split(line.strip())
                        if tag_name == tag_names[i] and len(content) >= len(cur[i]):
                            cur[i] = content
                if cur[0] not in [".", "-1"]:
                    writer.writerow(cur)
