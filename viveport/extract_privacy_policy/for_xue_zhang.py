import os

folder_paths = ['./res/', './res34/']
st = set()
cnt = set()
ok = set()
for folder_path in folder_paths:
    for filename in os.listdir(folder_path):
        cnt.add(filename[0:len(filename) - 2])
        full_file_path = os.path.join(folder_path, filename)
        s = ""
        with open(full_file_path, 'r', encoding='utf-8') as file:
            for i in file.readlines():
                i = i.strip()
                if "tag 隐私政策" in i:
                    if len(i) > len(s):
                        s = i
        if s != "":
            ok.add(s)
            with open("xue.txt", "a", encoding="utf-8") as f:
                w = s.split("|||")[-1]
                if w not in st:
                    print(w, file = f)
                    st.add(w)
print(len(cnt), len(ok)) # 3129 274