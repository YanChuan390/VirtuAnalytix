
sufs = []
with open("suf.txt", "r", encoding="utf-8") as f:
    for suf in f.readlines():
        sufs.append(suf.strip())

with open("urls.txt", "w", encoding="utf-8") as f:
    pref = "https://www.viveport.com/apps/"
    for suf in sufs:
        f.write(pref + suf + "\n")
