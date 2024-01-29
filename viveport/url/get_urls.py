from selenium import webdriver
from selenium.webdriver.common.by import By
import time
import sys

driver = webdriver.Chrome()
driver.get("https://www.viveport.com/filter-page/app")

def get_items():
  for i in range(3):
    time.sleep(1)
    
    # 修改选择器,定位img元素
    items = driver.find_elements(By.CSS_SELECTOR, "img.css-1njclh4")  
    if items:
      return items
      
  return None


while True:
    time.sleep(3)

    items = get_items()
    l = len(items)

    # 打印每个item的src属性
    for item in items:
       print(item.get_attribute('src'))

    # 点击翻页按钮
    next_btn = driver.find_element(By.CSS_SELECTOR, "button.chakra-button.css-q3t5kx")
    next_btn.click()
