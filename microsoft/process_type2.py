from selenium import webdriver
from selenium.webdriver.common.by import By
from bs4 import BeautifulSoup
import requests

import time, sys, os
from concurrent.futures import ThreadPoolExecutor
from type_of_url import get_type012

sys.path.append("d:/pro/py/pycpro1/utils/content_count_and_url_lazy/")

from lazy import get_and_save_page_source_once, delete_local_file_of_url, get_and_save_page_source

microsft_path = "d:/pro/py/pycpro1/microsoft/"
urls_path = os.path.join(microsft_path, "urls/urls.txt")
result_save_path_prefix = os.path.join(microsft_path, "type2_result/result2_")

cnt = []
def process_type2(url): 
    app_hash = url.split('?')[-2].split('/')[-1]
    save_path = result_save_path_prefix + app_hash + ".txt"
    with open(save_path, "r", encoding="utf-8") as f:
        for i in f.readlines():
            # if i.startswith("category:"):
            #     if len(i) > len("category: xx\n"):
            #         return
            if i.startswith("age_info:"):
                if len(i) > len("age_info: xx\n"):
                    return

    page_source = get_and_save_page_source(url)


    # final count
    if "copy" in page_source.lower():
        cnt.append(1)
        print("here")
    return


    soup = BeautifulSoup(page_source, 'html.parser')
    
    def first_tag_text(s):
        try:
            return soup.find(s).text
        except:
            return "-1"

    def id_href(s): 
        try:
            element = soup.find(id=s)
            return element['href']
        except:
            return "-1"
    
    def id_text(s):
        try:
            elements = soup.find_all(id=s)
            return ' '.join(e.text for e in elements)
        except:
            return "-1"

    name = first_tag_text("h1").replace('\n', ' ')
    description = first_tag_text("pre").replace("\n", " ").replace('\n', ' ')
    privacy_policy = id_href("privacyLink_desktop")
    age_info = id_text("matureContentText")
    category = id_text("categoryText")
    
    if name == "-1":
        with open("fail_urls5.txt", "a", encoding="utf-8") as f:
            f.write(url + "\n")
        delete_local_file_of_url(url)
        return
    with open(save_path, 'a', encoding='utf-8') as f:
        print("name:", name, file=f)
        print("origin_url:", url, file=f)
        print("description:", description, file=f)
        print("privacy_policy:", privacy_policy, file=f)
        print("age_info:", age_info, file=f)
        print("category:", category, file=f)

def main():
    with ThreadPoolExecutor(max_workers=5) as executor:
        with open(urls_path, 'r', encoding='utf-8') as f:
            for url in f.readlines():
                url = url.strip()
                if get_type012(url) != 2:
                    print(url)
                    continue
                executor.submit(process_type2, url)
main()
time.sleep(10)
print(cnt)
# process_type2("https://apps.microsoft.com/store/detail/fire-safty-training-vr-system/9N9NX8JL0GFR?hl=en-us&gl=us")
# process_type2("https://apps.microsoft.com/store/detail/nsquared-space-planner/9P8T0H2J4HZX?hl=en-us&gl=us")
# process_type2("https://apps.microsoft.com/store/detail/worklink-by-scope-ar/9NBLGGH4V339?hl=en-us&gl=us")
# process_type2("https://apps.microsoft.com/store/detail/holographic-remoting-player/9NBLGGH4SV40?hl=en-us&gl=us")

# fen("https://apps.microsoft.com/store/detail/wright-and-ferris-up-up-and-away/9N5WM62934PT?hl=en-us&gl=us")
# fen("https://apps.microsoft.com/store/detail/pseudoscience-6dof-viewer/9MTWV2P332TQ?hl=en-us&gl=us&rtc=1")
# fen("https://apps.microsoft.com/store/detail/eliza-ar-boatplan/9NV8GCDS8JLT?hl=en-us&gl=us")
# fen("https://apps.microsoft.com/store/detail/land-of-dinosaurs-vr/9P0HTFN2FC6T?hl=en-us&gl=us")
# fen("https://apps.microsoft.com/store/detail/museum-of-type/9PNH85F76RVP?hl=en-us&gl=us")
# fen("https://apps.microsoft.com/store/detail/museum-of-type/9PNH85F76RVP?hl=en-us&gl=us")

# # fen("https://www.microsoft.com/en-us/p/yogar/9p47cc593fh9")
# fen("https://www.microsoft.com/en-us/p/holo-cfd/9ndtz21vc8c6")
# fen("https://www.microsoft.com/en-us/p/mr-guide-trial/9n4t13mgvv93")
# fen("https://www.microsoft.com/en-us/p/machine-hunter-mixed-reality-game/9n1rgmlgh6k6")
# fen("https://www.microsoft.com/en-us/p/high-speed-railway-maintenance-beta/9n14vd6xlv8z")
# fen("https://apps.microsoft.com/store/detail/worklink-by-scope-ar/9NBLGGH4V339")
# fen("https://www.microsoft.com/en-us/p/zombiesmack/9nblggh532hp")
# fen("https://www.microsoft.com/en-us/p/airnotes/9phsgp1kt88c")
# fen("https://www.microsoft.com/en-us/p/prism-by-object-theory/9pjlwd0ls4w8")
# fen("https://www.microsoft.com/en-us/p/virtually-here/9ppdgqf2dzgf")
# fen("https://www.microsoft.com/en-us/p/holo-smartwatch/9pf7kbb0903k")
# fen("https://www.microsoft.com/en-us/p/greater-3d-player/9n35flth0xtr")
# fen("https://apps.microsoft.com/store/detail/cad-explorer/9N8FKT933DDQ")