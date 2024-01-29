from selenium import webdriver
from selenium.webdriver.common.by import By

# url 
# a.ClassName("psw-link psw-content-link") [0][1]...[len-1]


f = open("urls.txt", 'w', encoding='utf-8')

def urls(url):
    driver = webdriver.Chrome()
    driver.get(url)

    links = []
    if 1:
        lks = driver.find_elements(By.CLASS_NAME, "psw-link")
        for i in lks:
            if i.get_attribute("class") == "psw-link psw-content-link":
                links.append(i)
    print(len(links))

    for link in links:
        href = link.get_attribute("href")
        print(href, file=f, flush=True)
        
    driver.quit()

for i in range(1, 13 + 1):
    url = "https://store.playstation.com/en-sg/category/95239ca7-2dcf-43d9-8d4b-b7672ee9304a/" + str(i)
    urls(url)

