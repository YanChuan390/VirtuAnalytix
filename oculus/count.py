import csv
from selenium import webdriver
from selenium.webdriver.common.by import By
import time
import re
from selenium import webdriver
from selenium.webdriver.chrome.options import Options

# 相当于对url进行hash
def get_id_from_url(url):
    match = re.search(r'(\d+)', url)
    return match.group(0) if match else None

def replace_whitespaces(s):
    return re.sub('\s+', ' ', s)

def test_finish(driver):
    lst = driver.find_elements(By.CLASS_NAME, "app-details-row")
    return len(lst) > 0

def scrape_and_save_game_info_times1(url):

    driver = webdriver.Chrome()
    driver.get(url)

    # 判断页面上的信息是否已经加载完成
    fin = False
    for i in range(20):
        if test_finish(driver):
            fin = True
            break
        else:
            time.sleep(0.5)
    if not fin:
        print(f"info of url: {url}, 超时")
        raise Exception(f"info of url: {url}, 无法加载页面")


    time.sleep(3)
    # 游戏名称
    game_name = driver.find_element(By.CLASS_NAME, 'app-description__title').text

    game_age = driver.find_element(By.CLASS_NAME, 'app-age-rating__text').text

    # 游戏description、review
    game_description_list = [element.text for element in
                             driver.find_elements(By.CLASS_NAME, 'clamped-description__content')]
    game_description_list = [replace_whitespaces(description) for description in game_description_list]
    game_description = game_description_list[0]
    game_reviews = game_description_list[1:]
    for i in game_reviews:
        print(f'info of url: {url}, 游戏评论：{i}')

    time.sleep(1)

    # 游戏各项属性
    rows = driver.find_elements(By.CLASS_NAME, "app-details-row")
    game_properties = {}
    print(f"info of url: {url}, start游戏每个属性")
    for row in rows:
        try:
            title_element = row.find_element(By.CLASS_NAME, "app-details-row__left")
            content_element = row.find_element(By.CLASS_NAME, "app-details-row__right")

            title = title_element.text
            content = content_element.text

            game_properties[title] = content
        except Exception as e:
            print(f"info of url: {url}, RE：{e}")

    # 找到所有class名为"app-details-row__link"的元素
    links = driver.find_elements(By.CLASS_NAME, "app-details-row__link")

    print(f"info of url: {url}, start游戏隐私政策click")
    for link in links:
        # 点击包含"privacy"的
        if "privacy" in link.text.lower():
            # 使用JavaScript点击
            driver.execute_script("arguments[0].click();", link)
            print(f'info of url: {url}, new tab opened')
            time.sleep(3)
            break

    window_urls = []
    for handle in driver.window_handles:
        driver.switch_to.window(handle) # 切换到对应的窗口
        window_urls.append(driver.current_url)

    # 在game_properties中添加新的属性
    game_properties["Developer Privacy Policy"] = ', '.join(window_urls)

    # 创建和写入CSV文件
    with open(f'./csvs/game_info_{get_id_from_url(url)}.csv', 'w', newline='', encoding='utf-8') as file:
        writer = csv.writer(file)

        # 写入列名
        headers = ['game_name', 'game_description', "game_age"] + list(game_properties.keys()) + \
                                    [f'review_{i + 1}' for i in range(len(game_reviews))]
        writer.writerow(headers)

        # 写入数据
        data = [game_name, game_description, game_age] + list(game_properties.values()) + game_reviews
        writer.writerow(data)

    # 关闭浏览器驱动
    driver.quit()
    print(f'info of url: {url}, 爬取完成')

def scrape_and_save_game_info(url):
    for i in range(3): # 爬三次
        try:
            scrape_and_save_game_info_times1(url)
            return
        except:
            pass
    print(f"info of url: {url}, 爬取失败!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!")

if __name__ == '__main__':
    # 测试函数
    # scrape_and_save_game_info("https://www.oculus.com/experiences/quest/3695210323890200/?utm_source=oculusapplab.com")
    scrape_and_save_game_info('https://www.oculus.com/experiences/quest/3916248831731107/?utm_source=oculusapplab.com')