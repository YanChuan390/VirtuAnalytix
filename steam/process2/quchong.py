import re

# 注意文件路径更改

# part1
if __name__ == "__main1__": # origin_urls.txt -> urls.txt
    s = set()
    with open('origin_urls.txt', 'r', encoding='utf-8') as f:
        for i in f.readlines():
            s.add(i.strip())
    with open('urls.txt', 'w', encoding='utf-8') as f:
        for i in s:
            if "https://store.steampowered.com/app" in i:
                print(i, file=f)

# part: 对origin_map.txt去重，得到map.txt
if __name__ == "__main_x_": 
    s = set()
    with open('origin_map.txt', 'r', encoding='utf-8') as f:
        for i in f.readlines():
            s.add(i.strip())

    with open('map.txt', 'w', encoding='utf-8') as f:
        for i in s:
            print(i, file=f)

# part: 对origin_map.txt去重，并留下完整的，得到map_ok.txt
if __name__ == "__main__":
    s = set()
    with open('origin_map.txt', 'r', encoding='utf-8') as f:
        for i in f.readlines():
            s.add(i.strip())

    with open('map_ok.txt', 'w', encoding='utf-8') as f:
        for i in s:
            z = i[-5:]
            if "###" not in z and "none" not in z:
                print(i, file=f)



# part: 检查是否每个url都包含在origin_map.txt中了
if __name__ == "__main3__":
    def is_all_digits(s):
        return bool(re.fullmatch(r'\d+', s))
    s = set()
    with open('urls.txt', 'r', encoding='utf-8') as f:
        for i in f.readlines():
            s.add(i.strip())
            # for u in i.split('//'):
            #     if u.isdigit():
            #         s.add(u)
            #         break
    t = ""
    bad = 0
    with open('origin_map.txt', 'r', encoding='utf-8') as f:
        for i in f.readlines():
            j = i.strip()
            if "###" in j[-7:]:
                bad += 1
            t += i
    print(f"bad: {bad}")
    
    print("num s", len(s))
    fail = 0
    for i in s:
        if i not in t:
            fail += 1
    print("num fail", fail)

    #结果 6895个，只有488个没有出现