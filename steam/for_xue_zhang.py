urls = []
with open("d:\pro\py\pycpro1\steam\process_1_2_3/result123.txt", "r", encoding="utf-8") as f:
    for i in f.readlines():
        j = i.split("|||")[-1].strip()
        urls.append(j)

with open("d:\pro\py\pycpro1\steam\pp_urls.txt", "w", encoding="utf-8") as f:
    for i in urls:
        f.write(i + "\n")