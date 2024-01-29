import time
import sys
import random
from datetime import datetime

from appium import webdriver
from appium.webdriver.common.touch_action import TouchAction
from selenium.common.exceptions import NoSuchElementException, StaleElementReferenceException
from selenium.webdriver.common.by import By
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.support.ui import WebDriverWait


def mytap(driver, x, y):
    action = TouchAction(driver)
    action.tap(x=x, y=y).perform()


def sle(t, mst=''):
    print(f'todo: {mst}')
    time.sleep(t)
    print('finish sleep')


def scroll_down(driver, distance):
    window_size = driver.get_window_size()
    start_x = window_size["width"] / 2
    start_y = window_size["height"] / 2  # 起始位置设在屏幕中间
    end_x = start_x  # 水平方向不变
    end_y = start_y - distance  # 结束位置在起始位置上方

    # Ensure end_y is within screen bounds
    end_y = max(0, end_y)  # 确保 end_y 不小于 0
    end_y = min(window_size["height"], end_y)  # 确保 end_y 不大于屏幕高度

    actions = TouchAction(driver)
    actions.press(x=int(start_x), y=int(start_y))  # 开始按压
    actions.wait(1000)  # 使滑动更自然
    actions.move_to(x=int(end_x), y=int(end_y))  # 移动到结束位置
    actions.release()  # 松开屏幕
    actions.perform()  # 执行动作


def scroll_down_yy(driver, x, y0, y1):
    actions = TouchAction(driver)
    actions.press(x=int(x), y=int(y0))  # 开始按压
    actions.wait(1000)  # 等待，使滑动更自然
    actions.move_to(x=int(x), y=int(y1))  # 移动到结束位置
    actions.release()  # 松开屏幕
    actions.perform()  # 执行动作


# 水平滑动
def scroll_horizontal(driver, y, x_start, x_end):
    actions = TouchAction(driver)
    actions.press(x=int(x_start), y=int(y))  # 开始按压
    actions.wait(1000)  # 使滑动更自然
    actions.move_to(x=int(x_end), y=int(y))  # 移动到结束位置
    actions.release()  # 松开屏幕
    actions.perform()  # 执行动作


def write_string_to_file(s, filename='res.txt'):
    with open(filename, 'w', encoding='utf-8') as f:
        f.write(s)


def append_string_to_file(s, filename='result.txt'):
    with open(filename, 'a', encoding='utf-8') as f:
        f.write(s)


# 根据ID查找元素并点击
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


# 判断id是否存在
def check_element_exists(driver, element_id):
    print(f'Checking {element_id}')
    for i in range(10):
        try:
            WebDriverWait(driver, 20).until(
                EC.presence_of_element_located((By.ID, element_id))
            )
            print(f'Element with ID {element_id} found!')
            return True
        except Exception as e:
            print(f"Element with ID {element_id} not found within 20 seconds!")
    return False


# 根据xpath判断元素是否存在
def check_element_exists_by_xpath(driver, xpath):
    try:
        driver.find_element(By.XPATH, xpath)
        print(f'Element with XPATH {xpath} found!')
        return True
    except NoSuchElementException:
        print(f"Element with XPATH {xpath} not found!")
        return False


# 根据text查找元素并点击, lim时间内多次查找
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
                return True
        except (NoSuchElementException, StaleElementReferenceException):  # 如果找不到元素或元素过期，等待0.5秒后再次尝试
            time.sleep(0.5)
    return False


# 根据text判断元素是否存在
def is_element_present(driver, text):
    try:
        elements = driver.find_elements(By.XPATH, f"//*[contains(text(), '{text}')]")
        return len(elements) > 0
    except Exception as e:
        print(f"An error occurred: {e}")
        return False


def are_elements_present(driver, texts):
    try:
        page_source = driver.page_source
        return any(text in page_source for text in texts)
    except Exception as e:
        print(f"An error occurred: {e}")
        return False


# 点击含有text的元素
def expand_element(driver, text, justone=False, mn_x=-1):
    ok = False
    try:
        # 使用XPath获取包含"text"文本的元素
        elements = driver.find_elements(By.XPATH, f"//*[contains(@text, '{text}')]")

        # 遍历所有元素
        positions = []

        for element in elements:
            loc = element.location
            size = element.size
            # 计算元素的中心点
            center_x = loc['x'] + size['width'] / 2
            center_y = loc['y'] + size['height'] / 2
            if center_y < 1600 and center_x > mn_x:
                positions.append((center_x, center_y))

        # 按照second参数的值，将元素的中心点排序
        positions.sort(key=lambda x: x[1], reverse=True)
        print(positions)

        for i in range(len(positions)):
            center_x, center_y = positions[i]
            if i == 0:
                time.sleep(1)
                mytap(driver, center_x, center_y)
                if justone:
                    return True
            else:
                if abs(center_y - positions[i - 1][1]) > 100:
                    time.sleep(1)
                    mytap(driver, center_x, center_y)
                else:
                    continue

        if len(positions):
            ok = True
    except Exception as e:
        print(e)
    return ok


def find_text_locations_and_judge(driver, texts):
    ys = []

    try:
        # 获取所有元素
        elements = driver.find_elements(By.XPATH, "//*")

        for text in texts:
            for element in elements:
                try:
                    # 检查元素的text属性
                    element_text = element.text
                except Exception as e:
                    print(f"An error occurred when getting text of element: {e}")
                    continue

                # 如果元素的text包含我们关心的文本，获取它的中心点坐标
                if text in element_text:
                    loc = element.location
                    size = element.size
                    center_y = loc['y'] + size['height'] / 2
                    ys.append(center_y)
                    break
            else:
                # 如果没有找到元素，添加默认的坐标
                ys.append(int(1e9))
                break

    except Exception as e:
        print(f"An error occurred: {e}")
        sys.exit(0)

    return max(ys) <= 1680


def expand_the_element(driver, text):

    ls = []

    def tap_then_check_then_back(x, y):
        mytap(driver, x, y)
        time.sleep(3)
        if are_elements_present(driver, ['http', 'www']):
            ls.append(driver.page_source)
            driver.back()
            time.sleep(1)
        else:
            print('Can not back!!!!!!!!!!')

    try:
        elements = driver.find_elements(By.XPATH, "//*[not(string-length(@text) = 0)]")

        for element in elements:
            try:
                element_text = element.get_attribute('text')
            except Exception:
                continue
            if text in element_text:
                loc = element.location
                size = element.size
                # 计算元素的中心点
                center_x = loc['x'] + size['width'] / 2
                center_y = loc['y'] + size['height'] / 2
                if center_y < 1650:
                    tap_then_check_then_back(center_x, center_y)
                    return ls
    except Exception as e:
        print('expand_elements' + str(e))
    return ls


# 根据text查找元素并返回完整文本
def find_text_by_partial_text(driver, text):
    # 查找包含特定字符串的元素
    elements = driver.find_elements(By.XPATH, f"//*[contains(@text, '{text}')]")
    if elements:
        return elements[0].text
    return None


# 根据text_list查找以此开头的元素并返回字典
def find_text_by_starting_texts(driver, text_list):
    ans = dict()
    text_set = set(text_list)

    try:
        # 使用XPath找到所有text属性不为空的元素
        elements = driver.find_elements(By.XPATH, "//*[not(string-length(@text) = 0)]")

        for element in elements:
            try:
                element_text = element.get_attribute('text')
            except Exception as e:
                print(f"Error getting text attribute: {e}")
                continue

            # 遍历text_set寻找匹配的开始文本
            for text in text_set:
                if element_text.startswith(text):
                    ans[text] = element_text
            for text in ans.keys():
                if text in text_set:
                    text_set.remove(text)
                if not text_set:
                    return ans
    except Exception as e:
        print(f"Error finding elements: {e}")

    return ans


# 根据text_list查找包含此文本的元素并返回字典
def find_text_by_partial_texts(driver, text_list):
    ans = dict()
    text_set = set(text_list)

    try:
        # 使用XPath找到所有text属性不为空的元素
        elements = driver.find_elements(By.XPATH, "//*[not(string-length(@text) = 0)]")

        for element in elements:
            try:
                element_text = element.get_attribute('text')
            except Exception as e:
                print(f"Error getting text attribute: {e}")
                continue

            # 遍历text_set寻找匹配的部分文本
            for text in text_set:
                if text in element_text:
                    ans[text] = element_text
            for text in ans.keys():
                if text in text_set:
                    text_set.remove(text)
                if not text_set:
                    return ans
    except Exception as e:
        print(f"Error finding elements: {e}")

    return ans


# 查找第一个不为text空的元素
def find_first_not_none(driver):
    try:
        elements = driver.find_elements(By.XPATH, "//*[not(string-length(@text) = 0)]")
        return elements[0].text
    except Exception as e:
        print(f"没有名字?")
        return ""


# 返回所有text长度大于5的元素的text属性的列表
def get_text_over_five(driver):
    # 使用XPath找到所有text属性不为空的元素
    elements = driver.find_elements(By.XPATH, "//*[not(string-length(@text) = 0)]")
    long_texts = []  # 存储长度大于5的文本
    for element in elements:
        try:
            element_text = element.get_attribute('text')
            if len(element_text) > 5:
                long_texts.append(element_text)
        except Exception as e:
            print(f"Error getting text attribute: {e}")
            continue

    return long_texts


# y范围内的元素
def get_texts_of_elements_within_y_range(driver, y0, y1):
    all_elements = driver.find_elements(By.XPATH, "//*")
    texts = []
    for element in all_elements:
        loc = element.location
        size = element.size
        center_y = loc['y'] + size['height'] / 2
        if y0 <= center_y <= y1 and len(element.text) > 5:  # 长度大于5
            texts.append(element.text)
    return texts


def get_pjcs(driver, text):  # 获取评价次数
    try:
        elements = driver.find_elements(By.XPATH, f"//*[contains(@text, '{text}')]")

        for element in elements:
            loc = element.location
            size = element.size
            # 计算元素的中心点
            center_x = loc['x'] + size['width'] / 2
            center_y = loc['y'] + size['height'] / 2
            x = ""
            try:
                x = element.text
            except Exception as e:
                pass
            return (center_x, center_y, x)

    except Exception as e:
        print(e)
        return None


def now_t():
    now = datetime.now()
    return now.strftime("%Y-%m-%d %H:%M:%S")


def zhankai(driver):
    re = expand_element(driver, '展开', mn_x=940)
    time.sleep(0.3)
    return re


def update_ans(ans, dict0):
    for k, v in dict0.items():
        ans.update({k: v})


def just_names(path='names.txt'):
    re = ''
    with open(path, 'r', encoding='utf-8') as f:
        re = f.read()
    return re


import csv


def write_dict_to_csv(dictionary, filename):
    keys = list(dictionary.keys())
    values = list(dictionary.values())
    with open(filename, 'w', encoding='utf-8', newline='') as f:
        writer = csv.writer(f)
        writer.writerow(keys)  # 写入键（即列名）
        writer.writerow(values)  # 写入值（即数据）


def main(id):
    def new_driver():
        driver = webdriver.Remote(appium_server_url, desired_caps)
        for i in driver.get_settings().items():
            print(i)
        return driver

    desired_caps = {
        "platformName": "Android",
        "deviceName": "123",
        "platformVersion": "10.0",
        'noReset': True,  # 不重置应用状态
        'noSign': True,  # 不重新签名应用
        'newCommandTimeout': 99999,  # 设定新命令超时时间
        'waitForIdleTimeout': 10,
        'udid': id,
    }

    appium_server_url = "http://localhost:4723/wd/hub"

    driver = new_driver()

    # print('st')
    # ls = expand_the_element(driver, '开发者隐私政策')
    # print('fin')
    # print(ls)
    #
    # return

    text_list = [
        '年龄',
        '支持退款',
        '不支持退款',
        '分类',
        '标签',
        '游戏形式',
        '语言',
        '使用范围',
        '控制方式',
        '支持平台',
        '版本',
        '更新日期',
        '大小',
        '开发者',
        '发行商',
        '开发者隐私政策',
        '开发者服务条款',
        '开发者网站',
        '权限'
    ]

    xpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget" \
            ".LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget" \
            ".FrameLayout[2]/android.widget.TextView"

    while 1:
        # if len(rep) > 10 and rep[-1] + rep[-2] + rep[-3] == 3:
        #     check_and_click_element_by_text(driver, '应用')
        #     time.sleep(10)
        #     check_and_click_element_by_text(driver, '应用')
        #     time.sleep(10)

        print('点击')
        mytap(driver, 160, 360)
        time.sleep(3)

        print('商店')
        if not check_element_exists_by_xpath(driver, xpath):

            print('获取name')
            name = find_first_not_none(driver)
            print(f'name: {name}')

            print('checking if exist')
            if name not in just_names('names.txt') and name not in just_names('naming.txt'):
                print('name not exist')
                append_string_to_file(name + '\n', 'naming.txt')
                # rep.append(0)
                strat_time = now_t()  # 年月日时分秒
                ans = dict()

                ans.update({'name': name})
                print('展开')
                zhankai(driver=driver)  # 展开
                print('获取简介')
                r = find_text_by_starting_texts(driver, ['简介'])
                update_ans(ans, r)
                print(ans)

                # pjcs = ''
                # pj = []
                #
                # ji1 = 0
                # while not pjcs:
                #     ji1 += 1
                #     if ji1 > 10:
                #         break
                #     print('查看全部')
                #     if not expand_element(driver, '查看全部', mn_x=800):
                #         scroll_down_yy(driver, 800, 1100, 700)
                #         time.sleep(0.5)
                #         continue
                #
                #     print('全部评价')
                #     time.sleep(2)
                #     if not is_element_present(driver, '全部评价'):
                #         driver.back()
                #         time.sleep(1)
                #         scroll_down_yy(driver, 800, 1150, 700)
                #         continue
                #
                #     print('评价次数')
                #     pjcs = get_pjcs(driver, '评价次数')
                #     for i in range(3):
                #         print('评价内容')
                #         pj += get_text_over_five(driver)
                #         scroll_down_yy(driver, 800, 1750, 350)
                #         time.sleep(0.7)
                #
                #     driver.back()
                #     break
                #
                # print(pjcs, pj)

                ji1 = 0
                zan = False
                while '权限' not in ans or not find_text_locations_and_judge(driver, ['权限']):
                    ji1 += 1
                    if ji1 > 15:
                        break

                    if not zan:
                        print('展开')
                        if zhankai(driver=driver):  # 展开
                            zan = True

                    scroll_down_yy(driver, 800, 1100, 700)

                    print('list')
                    r = find_text_by_starting_texts(driver, text_list)
                    update_ans(ans, r)

                end_time = now_t()
                ans['名称'] = name
                ans['start'] = strat_time
                ans['end'] = end_time
                # ans.update({'评分': pjcs})
                # ans.update({'评价': pj})
                dn = datetime.now().strftime("%Y-%m-%d_%H_%M_%S")
                # append_string_to_file(str(ans) + '\n')
                append_string_to_file(ans['name'] + '\n', filename='names.txt')
                x = random.randint(1, 10000000)
                write_dict_to_csv(ans, f'./csvs/result_csv({dn})_{x}.csv')
                for i in ans.items():
                    print(i)
            else:
                print('name exist')

            print('back')
            driver.back()
            time.sleep(1)
        else:
            print('空')

        time.sleep(1)
        print('滑动')
        scroll_down(driver, 90)
        time.sleep(1)


if __name__ == '__main__':
    main('emulator-5556')
