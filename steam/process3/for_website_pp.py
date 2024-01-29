
'''
对website_ok.txt中的每个'url='后面部分的url
爬此url
结果保存到website_pp.txt中
格式为url|||pp_url
'''

from selenium import webdriver
from selenium.webdriver.common.by import By
from concurrent.futures import ThreadPoolExecutor
import sys, time
import random

def fetch_privacy_links(target_url):
    try:
        # 初始化WebDriver
        driver = webdriver.Chrome()
        driver.set_page_load_timeout(60)
        try:
            driver.get(target_url)
        except:
            pass
        time.sleep(3)

        keywords = [
            "privacy",
            "隐私",
            "隱私",
            "プライバシー", "ポリシー",
            "confidentialité",
            "Datenschutz",
            "privacidad",
            "конфиденциальности",
            "الخصوصية",
        ]

        xpath_expression = "//*["
        for idx, keyword in enumerate(keywords):
            lower_keyword = keyword.lower()
            if idx > 0:
                xpath_expression += " or "
            xpath_expression += f"contains(translate(text(), 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'), '{lower_keyword}')"
        xpath_expression += "]"
        time.sleep(2)
        elements = driver.find_elements(By.XPATH, xpath_expression)
        _current_url = driver.current_url
        for element in elements:
            for keyword in keywords:
                if keyword in element.text.lower():
                    element.click()
                    time.sleep(3)
                    for handle in driver.window_handles:
                        driver.switch_to.window(handle)
                        if driver.current_url != _current_url:
                            return driver.current_url
        driver.quit()
        return "-1"
    except:
        return "-1"

def g(url):
    re = fetch_privacy_links(url)
    with open("website_pp.txt", "a", encoding="utf-8") as f:
        f.write(url + "|||" + re + '\n')

urls = []
with open("process2/map_ok.txt", "r", encoding='utf-8') as f:
    for i in f.readlines():
        urls.append(i.strip().split("url=")[-1])

print(len(urls))
urls = urls + urls + urls
random.shuffle(urls)
print(len(urls))
with ThreadPoolExecutor(max_workers=7) as executor:
    executor.map(g, urls)

# urls.append("https://www.halfbrick.com/games/fruit-ninja-vr")
# urls.append("https://mirowin.com") #
# urls.append("https://www.bhaptics.com/")
# urls.append("http://vrskater.deficit.games/")
# urls.append("http://www.zenzvr.com/")
# urls.append("http://fieldof.vision/DistantNightmare.html")
# urls.append("http://www.jp.square-enix.com/mangainvr/weddingring/")
# urls.append("https://login.squarespace.com/api/1/login/oauth/provider/authorize?client_id=wAHMs0yNCd2CyyoI0Eclva4GmZ1qqRPx&redirect_uri=https%3A%2F%2Fdrbloc.squarespace.com%2Foauth-connect&state=v1.local.da18SAO17oICTTitOCNU6dcWk737-lfKz5MlqmSNmBdtC8QY6B_m2nE9mFzkyiZzJ7i04bCf81SHhZMyZaI7eirmS5OK1szPyRulbJCiM1eC7TrCOfbZo0JK4mn_ezk44K7-vwQBNBaNLmUcsIvPg3RLtgyQAW89UNPLvEALAp16_mvg3W9QlLUlyYsKAchtdrLp4LeUF1UknZ32lsSthVoyXZXTfPdI_6KsMksJOV_9TbcLpFu9EvIAishieSrc7Ufam-Lg07jy_gVXVDrwS-kwwbakp_tEcu3VOkeCH1ShCg8UQGRBRDlJ9T60&overrideLocale=en-US&options=%7B%22isCloseVisible%22%3Afalse%2C%22isCreateAccountViewActive%22%3Afalse%7D#/")
