from selenium import webdriver
from selenium.webdriver.common.by import By
import time, sys, os
from bs4 import BeautifulSoup

from concurrent.futures import ThreadPoolExecutor

sys.path.append("d:/pro/py/pycpro1/utils/content_count_and_url_lazy/")
from lazy import get_and_save_page_source_once, delete_local_file_of_url, get_and_save_page_source

microsft_path = "d:/pro/py/pycpro1/microsoft/"
urls_path = os.path.join(microsft_path, "urls/urls.txt")
result_save_path_prefix = os.path.join(microsft_path, "type1_result/result1_")

cnt = set()
def find_1(driver, f_name): # 详细
    def id_text(s):
        try:
            return driver.find_element(By.ID, s).text
        except:
            return "-1"

    f_name = result_save_path_prefix + f_name + ".txt"
    name = id_text("DynamicHeading_productTitle")
    descrip = id_text("product-description").replace("\n", " ")
    pp = "-1"

    try:
        a_elements = driver.find_elements(By.CLASS_NAME, "c-hyperlink")
        for a_element in a_elements:
            te = a_element.text.lower()
            if "privacy" in te or "隐私" in te:
                pp = a_element.get_attribute('href')
                break
    except:
        print(f"fail1: {f_name}")
    
    def fetch_children_recursively(element):
        ls = []
        children = element.find_elements(By.XPATH, "./*")
        for child in children:
            t = child.text
            if child.tag_name == "a":
                t += "@" + child.get_attribute('href')
            ls.append(t)
            ls.extend(fetch_children_recursively(child))
        return ls

    info = {}
    h4_elements = driver.find_elements(By.TAG_NAME, "h4")
    for h4 in h4_elements:
        try:
            parent_element = h4.find_element(By.XPATH, "./..")
            ls = fetch_children_recursively(parent_element)
            info[h4.text] = "|||".join([i.replace("\n", " ") for i in ls])
        except:
            continue
                
    with open(f_name, 'a', encoding='utf-8') as f:
        print("name:", name, file=f)
        print("description:", descrip, file=f)
        print("privacy_policy:", pp, file=f)
        for key, value in info.items():
            u = key.replace("\n", " ").replace(" ", "_")
            print(f"{u}:", value, file=f)

def fen(url, tt=0):
    try:
        assert url.endswith("?hl=en-us&gl=us")
        page_source = get_and_save_page_source_once(url)


        # {begin} 临时插入的代码，统计是否含有copy right, sys req
        soup = BeautifulSoup(page_source, 'html.parser')
        text_content = soup.get_text().lower()
        # if "copyright" in text_content or "copy right" in text_content or "copy" in text_content:
        # if "system req" in text_content:
        if "reviews" in text_content:
            cnt.add(url.split("?")[0].split("/")[-1])
        return
        # {end} 临时插入的代码，统计是否含有copy right, sys req


        app_hash = url.split('?')[-2].split('/')[-1] # 问号前面，/后面的部分

        driver = webdriver.Chrome()
        driver.set_page_load_timeout(60)
        driver.get(url) # 这里如果没有加载成功，会抛异常，然后递归tt
        time.sleep(2)

        u = set(driver.current_url.split('/'))
        if "store" not in u:
            find_1(driver, app_hash)
        driver.quit()

    except:
        try:
            driver.quit()
        except:
            pass
        if tt < 2:
            fen(url, tt + 1)

def main():
    with open(urls_path, 'r', encoding='utf-8') as f:
        lines = [line.strip() for line in f.readlines()]
    print(len(lines))

    with ThreadPoolExecutor(max_workers=7) as executor:
        for i in lines:
            executor.submit(fen, i)
main()
fen("https://www.microsoft.com/en-us/p/typography-insight-for-hololens/9nblggh4tkdk?hl=en-us&gl=us")
time.sleep(3)
print(cnt)
print(len(cnt))


# fen("https://apps.microsoft.com/store/detail/nsquared-space-planner/9P8T0H2J4HZX?hl=en-us&gl=us")
# fen("https://apps.microsoft.com/store/detail/worklink-by-scope-ar/9NBLGGH4V339?hl=en-us&gl=us")
# fen("https://apps.microsoft.com/store/detail/holographic-remoting-player/9NBLGGH4SV40")

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