

o_pp = dict()

err_cnt = 0
with open("./../process3/website_pp.txt", "r", encoding="utf-8") as f:
    for i in f.readlines():
        i = i.strip()
        if ("###" not in i) and ("|||" in i):
            try:
                official_url, pp_url = i.split("|||")
                official_url = official_url.strip()
                pp_url = pp_url.strip()
                if len(pp_url) > 4 and official_url not in o_pp:
                    o_pp.update({official_url: pp_url})
            except:
                err_cnt += 1
print(f"err_cnt: {err_cnt}")

# w = list(o_pp.items())
# print(w[0:10])

list3 = []

err_cnt2 = 0
no_url_e = 0
no_pp = 0
with open("./../process2/map_ok.txt", "r", encoding="utf-8") as f:
    for i in f.readlines():
        try:
            l, r = i.split("###")
            l = l.strip()
            r = r.strip()
            if "url=" in r:
                l = l
                r = r.split("url=")[-1]
                print(l, r)
                if r in o_pp:
                    list3.append((l, r, o_pp[r]))
                else:
                    no_pp += 1
            else:
                no_url_e += 1

        except:
            err_cnt2 += 1

print(f"len_list3: {len(list3)}")
print(f"err_cnt2: {err_cnt2}")
print(f"nourl_e: {no_url_e}")
print(f"no_pp: {no_pp}")

with open("./result123.txt", "w", encoding="utf-8") as f:
    for i in list3:
        f.write(i[0] + " ||| " + i[1] + " ||| " + i[2] + "\n")