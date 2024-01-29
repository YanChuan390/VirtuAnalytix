'''
把website_pp.txt和map_ok.txt中的所有url的page_source保存到本地
'''

import sys
from concurrent.futures import ThreadPoolExecutor
import random

sys.path.append("D:/pro/py/pycpro1/url_lazy")
from main import get_and_save_page_source
from main import get_page_source_from_file
from main import check_is_saved

def main():
    u = set()
    # with open("website_pp.txt", "r", encoding="utf-8") as f:
    #     for i in f.readlines():
    #         i = i.strip()
    #         for j in i.split("|||"):
    #             for k in j.split("###"):
    #                 u.add(k.strip())

    # with open("./process2/map_ok.txt", "r", encoding="utf-8") as f:
    #     for i in f.readlines():
    #         for j in i.split("###"):
    #             j = j.strip()
    #             if j.startswith("https://steamcommunity.com/linkfilter/?url="):
    #                 for k in j.split("https://steamcommunity.com/linkfilter/?url="):
    #                     if k:
    #                         if k.strip():
    #                             u.add(k.strip())
    #             else:
    #                 u.add(j)

    with open("./../process_1_2_3/result123.txt", "r", encoding="utf-8") as f:
        for i in f.readlines():
            for j in i.split(" ||| "):
                u.add(j.strip())

    u = list(u)
    random.shuffle(u)
    # 使用ThreadPoolExecutor进行并行处理
    with ThreadPoolExecutor(max_workers=7) as executor:
        executor.map(get_and_save_page_source, u)

if __name__ == "__main__":
    main()
