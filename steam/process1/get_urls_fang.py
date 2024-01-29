# from selenium import webdriver
# from selenium.webdriver.common.by import By
# import time

# def sss(driver):
#     try:
#         re = set()
#         a_elements = driver.find_elements(By.TAG_NAME, 'a')
#         for a in a_elements:
#             href = str(a.get_attribute('href'))
#             if href and "app" in href:
#                 re.add(href)
#         return re
#     except:
#         return set()

# def fa(url, ci=0):
#     print(ci)
#     try:
#         driver = webdriver.Chrome()
#         driver.set_page_load_timeout(60)
#         driver.get(url)  # 请替换为您实际要访问的网址
#         time.sleep(5)
#         s = sss(driver)
#         for _ in range(3):
#             s.update(sss(driver))
#         with open('result.txt', 'a') as f:
#             for i in s:
#                 f.write(f"{i}\n")
#         driver.quit()
#     except Exception as e:
#         if ci < 3:
#             fa(url, ci + 1)

# # for i in range(1, 550):
# #     fa('https://store.steampowered.com/vr/' + str(i * 10))

# from concurrent.futures import ThreadPoolExecutor
# with ThreadPoolExecutor(max_workers=5) as executor:
#     urls = ['https://store.steampowered.com/vr/' + str(i * 10) for i in range(1, 551)]
#     executor.map(fa, urls)


from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from bs4 import BeautifulSoup
import time
import sys

driver = webdriver.Chrome()
url = "https://store.steampowered.com/vr/"
driver.get(url)
time.sleep(3)

s = set()

mxlen = 10
szlist = [0] * mxlen
idx = 0

while True:
    try:
        wait = WebDriverWait(driver, 10)
        buttons = driver.find_elements(By.TAG_NAME, "button")
        for b in buttons[::-1]:
            if b.text == "显示更多":
                b.click()
                break
        html = driver.page_source
        soup = BeautifulSoup(html, 'html.parser')
        for a_tag in soup.find_all('a'):
            s.add(a_tag.get('href'))
        time.sleep(3)
    except Exception as e:
        print("error", e)
    print(f"idx: {idx}, sz: {len(s)}")
    szlist[idx % mxlen] = len(s)
    idx += 1
    if len(set(szlist)) == 1: 
        break
    with open("origin_urls.txt", "w", encoding='utf-8') as f:
        for i in s:
            f.write(str(i) + "\n")
try:
    driver.quit()
except:
    pass

# 6200 finished
urls = []
with open("origin_urls.txt", "r", encoding='utf-8') as f:
    for i in f.readlines():
        if "app" in i.strip():
            urls.append(i.strip())
urls = urls[100:-1]

def f(url):
    print(f"url: {url}")
    res = ""
    try:
        driver = webdriver.Chrome()
        driver.set_page_load_timeout(60)
        driver.get(url)
        time.sleep(3)
        alist = driver.find_elements(By.TAG_NAME, "a")
        for a in alist:
            if "访问网站" in a.text:
                res = a.get_attribute("href")
                break
    except:
        res = "none"
    with open("origin_map.txt", "a", encoding="utf-8") as f:
        f.write(str(url) + " ### " + str(res) + "\n")

if __name__ == "__main__":
    from concurrent.futures import ProcessPoolExecutor
    with ProcessPoolExecutor(max_workers=5) as executor:
        executor.map(f, urls)