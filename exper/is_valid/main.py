from selenium import webdriver
from selenium.common.exceptions import NoSuchElementException, TimeoutException
from selenium.webdriver.common.by import By
import time

def is_page_valid(url, timeout=60, keywords=None):
    if keywords is None:
        keywords = ["privacy", "隐私", "プライバシー", "confidentialité", "Datenschutz", "privacidad", "конфиденциальности", "الخصوصية"]
    
    # 初始化webdriver
    driver = webdriver.Chrome()

    # 设置页面加载超时时间
    driver.set_page_load_timeout(timeout)

    try:
        # 尝试访问页面
        driver.get(url)
    except TimeoutException:
        pass  # 页面加载超时，但我们仍然会检查已加载的部分

    # 构造XPath表达式
    xpath_expression = "//*["
    for idx, keyword in enumerate(keywords):
        lower_keyword = keyword.lower()
        if idx > 0:
            xpath_expression += " or "
        xpath_expression += f"contains(translate(text(), 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'), '{lower_keyword}')"
    xpath_expression += "]"

    time.sleep(2)  # 等待页面的进一步加载（如果有）

    try:
        elements = driver.find_elements(By.XPATH, xpath_expression)
        for element in elements:
            for keyword in keywords:
                if keyword.lower() in element.text.lower():
                    driver.quit()
                    return True  # 找到了关键字，页面有效
    except NoSuchElementException:
        pass  # 没有找到任何元素，继续

    # 关闭浏览器
    driver.quit()

    return False  # 没有找到关键字，页面无效

def wrap_valid(url):
    x = is_page_valid(url)
    with open("check.txt", "r", encoding="utf-8") as f:
        print(url + "|||" + x, file=f)


