import re

def extract_app_id(url: str) -> str:
    match = re.search(r'/app/(\d+)/', url)
    return match.group(1) if match else None

if __name__ == "__main__":
    s = set()
    with open("./urls.txt", "r", encoding="utf-8") as f:
        for i in f.readlines():
            s.add(extract_app_id(i.strip()))
    print(len(s)) # 并不是6082

if __name__ == "__main__x":
    # 测试
    url = "https://store.steampowered.com/app/1623390/Unplugged?snr=1_1453_4__salebrowseall"
    app_id = extract_app_id(url)
    if app_id:
        print(app_id)
    else:
        print("No match found.")