from appium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
import time
import re
from appium.webdriver.common.mobileby import MobileBy
from selenium.common.exceptions import NoSuchElementException, StaleElementReferenceException
import winsound


def write_string_to_file(s, filename='res.txt'):
    with open(filename, 'w') as f:
        f.write(s)

def check_and_click_button(driver, button_id):
    print(f'st {button_id}')
    for i in range(10):
        try:
            button = WebDriverWait(driver, 20).until(
                EC.presence_of_element_located((By.ID, button_id))
            )
            button.click()
            print(f'ed {button_id}')
            return
        except Exception as e:
            print(f"Button with ID {button_id} not found within 20 seconds!")


def check_and_click_element_by_text(driver, element_text, lim=100):
    print(f'st {element_text}')

    start_time = time.time()  # 获取当前时间
    while time.time() - start_time < lim:
        print(f'checking {element_text}')
        try:
            element = driver.find_element(By.XPATH, f"//*[contains(@text, '{element_text}')]")  # 尝试查找元素
            if element:
                element.click()  # 如果找到元素，点击它
                print(f'ed {element_text}')
                return
        except (NoSuchElementException, StaleElementReferenceException):  # 如果找不到元素或元素过期，等待0.5秒后再次尝试
            time.sleep(0.5)

    # 如果在lim秒内找不到元素，抛出异常
    print(f"Element with text '{element_text}' not found within {lim} seconds!")
    raise NoSuchElementException(f"No such element: Unable to locate element with text {element_text}")

def sle(t, mst=''):
    print(f'todo: {mst}')
    time.sleep(t)
    print('finish sleep')

from appium.webdriver.common.touch_action import TouchAction

def scroll_down(driver):
    window_size = driver.get_window_size()
    start_x = window_size["width"] / 2
    start_y = window_size["height"] / 2  # 起始位置设在屏幕中间
    end_x = start_x  # 水平方向不变
    end_y = start_y - 90  # 结束位置在起始位置上方100像素

    # Ensure end_y is within screen bounds
    end_y = max(0, end_y)  # 确保 end_y 不小于 0
    end_y = min(window_size["height"], end_y)  # 确保 end_y 不大于屏幕高度

    actions = TouchAction(driver)
    actions.press(x=int(start_x), y=int(start_y))  # 开始按压
    actions.wait(1000)  # 可以加一个等待时间，使滑动更自然
    actions.move_to(x=int(end_x), y=int(end_y))  # 移动到结束位置
    actions.release()  # 松开屏幕
    actions.perform()  # 执行动作

desired_caps = {
    "platformName": "Android",
    "deviceName": "123",
    "platformVersion": "10.0",
    "appPackage": "com.picovr.assistantphone",
    "appActivity": "com.picovr.assistantphone.ui.MainActivity"
}

appium_server_url = "http://localhost:4723/wd/hub"

driver = webdriver.Remote(appium_server_url, desired_caps)
desired_caps['settings[waitForIdleTimeout]'] = 100
driver.update_settings({'waitForIdleTimeout': 100})
print('here')
print(driver.page_source)
check_and_click_button(driver, "com.picovr.assistantphone:id/alert_dialog_yes_button")
check_and_click_element_by_text(driver, "商店")

sle(5)

ylp = [(456, 193)]
zanp = [(470, 1320)]
op = [(164, 376)]

for i in range(4):
    sle(10, 'find 娱乐')
    driver.tap(ylp)

print('yes')

ji = 0
while 1:
    sle(5, 'tap')
    driver.tap(op)

    sle(5, 'get source')
    s = driver.page_source
    # 追加写入
    with open('res.txt', 'a', encoding='utf-8') as f:
        f.write(s)

    sle(1, 'back')
    # 返回，发送系统back按键
    driver.back()

    if ji < 1:
        ji = 1
        winsound.Beep(2500, 2000) # 频率为2500，持续时间为 毫秒
        sle(5, 'wait for 暂不选择'); driver.tap(zanp)

        for i in range(4):
            sle(10, 'find 娱乐'); driver.tap(ylp)
    sle(3, 'scroll down')
    scroll_down(driver)


# def find_and_click_element_by_size(driver, bounds):
#     # 解析bounds字符串获取宽度和高度
#     match = re.match(r'\[(\d+),(\d+)\]\[(\d+),(\d+)\]', bounds)
#     if match:
#         expected_width = int(match.group(3)) - int(match.group(1))
#         expected_height = int(match.group(4)) - int(match.group(2))
#
#         # 获取屏幕上的所有元素
#         elements = driver.find_elements(MobileBy.XPATH, "//*")
#
#         # 遍历所有元素，找到第一个满足条件的元素
#         for element in elements:
#             if element.is_displayed():
#                 size = element.size
#                 if size['width'] == expected_width and size['height'] == expected_height:
#                     # 找到元素，点击并退出函数
#                     element.click()
#                     return
#     else:
#         print(f'Invalid bounds format: {bounds}')
# 使用示例：
# find_and_click_element_by_size(driver, "[46,468][364,648]")


