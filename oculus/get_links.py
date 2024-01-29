import time
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.common.exceptions import StaleElementReferenceException

def extract_links(url):
    driver = webdriver.Chrome()
    driver.get(url)
    time.sleep(5)
    links_set = set()
    last_ten_lengths = [0] * 10

    while True:
        driver.execute_script("window.scrollBy(0, window.innerHeight / 3);")
        time.sleep(3)
        app_links = driver.find_elements(By.CLASS_NAME, "app_link")
        for link in app_links:
            try:
                links_set.add(link.get_attribute("href"))
            except StaleElementReferenceException:
                pass
        last_ten_lengths.append(len(links_set))
        last_ten_lengths.pop(0)
        if len(set(last_ten_lengths)) == 1:
            msg = input("finish")
            break
    driver.quit()
    with open("app_links_origin.txt", "a") as file:
        for link in links_set:
            file.write(link + "\n")

if __name__ == "__main__":
    # extract_links("https://questgamelist.com/Best")
    extract_links("https://applabgamelist.com/Best")