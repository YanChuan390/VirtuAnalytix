# h2标签 class: base mb-2 h6 下的a标签就是对应的链接
from selenium import webdriver
from selenium.webdriver.common.by import By

def get_links(url):
    driver = webdriver.Chrome()
    driver.get(url)

    h2_list = driver.find_elements(By.CSS_SELECTOR, 'h2.base.mb-2')

    links = []
    for h2 in h2_list:
        a_list = h2.find_elements(By.TAG_NAME, 'a')
        for a in a_list:
            link = a.get_attribute('href')
            links.append(link)

    driver.quit()
    return links

if __name__ == '__main__':
    urls = []
    urls.append('https://www.microsoft.com/en-us/store/collections/hlgettingstarted/hololens')
    urls.append('https://www.microsoft.com/en-us/store/collections/hlgettingstarted/hololens?skipitems=90')
    urls.append('https://www.microsoft.com/en-us/store/collections/hlgettingstarted/hololens?skipitems=180')
    urls.append('https://www.microsoft.com/en-us/store/collections/hlgettingstarted/hololens?skipitems=270')
    urls.append('https://www.microsoft.com/en-us/store/collections/mr-all-immersivecontent')
    urls.append('https://www.microsoft.com/en-us/store/collections/mr-all-immersivecontent/?skipitems=90')
    urls.append('https://www.microsoft.com/en-us/store/collections/mr-playgamesall')

    results = set()
    for url in urls:
        links = get_links(url)
        print(len(links))
        for i in links:
            results.add(i)

    with open('origin_urls.txt', 'w', encoding='utf-8') as f:
        for i in results:
            print(i, file=f, flush=True)