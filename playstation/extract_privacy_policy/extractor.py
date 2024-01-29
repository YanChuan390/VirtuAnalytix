import os

folder_path = './res/'
cnt = 0
ok = 0
for filename in os.listdir(folder_path):
    cnt += 1
    full_file_path = os.path.join(folder_path, filename)
    with open(full_file_path, 'r', encoding='utf-8') as file:
        s = ""
        for i in file.readlines():
            i = i.strip()
            if "tag_pp" in i:
                s = i
        if s[-3:] != "..." and "notice" not in s:
            ok += 1
            with open("xue.txt", "a", encoding="utf-8") as f:
                s = s[7:]
                print(s, file=f)
print(cnt, ok) # 301 34