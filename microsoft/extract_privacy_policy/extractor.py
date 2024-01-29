import os

file_contents = {}
folder_paths = ['./../type1_result/', './../type2_result/']

cnt = 0
ok = 0
for folder_path in folder_paths:
    for filename in os.listdir(folder_path):
        print(filename)
        cnt += 1
        full_file_path = os.path.join(folder_path, filename)
        s = ""
        with open(full_file_path, 'r', encoding='utf-8') as file:
            for i in file.readlines():
                i = i.strip()
                if "privacy_policy" in i:
                    if len(i) > len(s):
                        s = i
        print(s)
        if s[-2:] != "-1":
            ok += 1
            with open("privacy_policys.txt", "a", encoding="utf-8") as f:
                print(s.split(": ")[-1], file = f)
print(cnt, ok) # 460, 206