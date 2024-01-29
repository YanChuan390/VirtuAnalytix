import csv
import re

import pandas as pd
from selenium import webdriver
from selenium.webdriver.common.by import By
from time import sleep
from selenium.webdriver.chrome.options import Options
from waybackpy import WaybackMachineSaveAPI
USER_AGENT = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/102.0.0.0 Safari/537.36"
def getFrequency(url):
    #Replace the local driver path
    chrome_driver_path = '/Users/chuan/chrome-mac-arm64'
    # bor = webdriver.Chrome(executable_path='chromedriver')
    chrome_options = webdriver.ChromeOptions()
    bor = webdriver.Chrome(options=chrome_options)
    # options = webdriver.ChromeOptions()
    # options.headless = True
    # bor = webdriver.Chrome(options=options)
    bor.get('https://archive.org/web/')
    # bor.get('https://www.getbring.com/en/privacy-policy')
    # input button
    input_box = bor.find_element(by=By.ID,value='wwmurl')
    try:
        input_box.send_keys(url)
    except Exception:
        pass
    # search button
    button = bor.find_element(by=By.NAME , value='type')
    try:
        button.click()
    except Exception:
        pass

    sleep(5)
    startTime = None
    endTime = None
    captures = None
    duplicates = None
    uniques = None
    # newOne = None
    # find time
    # try:
    #     times = bor.find_element(by=By.CLASS_NAME , value='captures-range-info').find_element(by=By.TAG_NAME , value='strong').text
    #     interval = bor.find_element(by=By.CLASS_NAME , value='captures-range-info').find_elements(by=By.TAG_NAME , value='a')
    #     startTime = interval[0].text
    #     endTime = interval[1].text
    #     # save_api = WaybackMachineSaveAPI(url, USER_AGENT)
    #     # save_api.save()
    #     # newOne = save_api.timestamp()
    # except Exception:
    #     print(111)
    #     pass
    try:
        url_button = bor.find_element(by=By.ID, value='react-wayback-search').find_element(by=By.CLASS_NAME,value='view-navbar').find_elements(by=By.TAG_NAME,value='a')
        # url_button = bor.find_element(by=By.ID,value='react-wayback-search').find_element(by=By.CLASS_NAME,value='view-navbar').find_element(by=By.CLASS_NAME,value='navbar-option beta-badge-container selected-option')
        url_button[-1].click()
    except:
        pass
        print("not find urlbutton")

    sleep(2)

    try:
        root = bor.find_element(by=By.ID,value='url-query-result').find_element(by=By.ID,value='resultsUrl_wrapper').find_elements(by=By.CLASS_NAME,value='row')[1].find_element(by=By.CLASS_NAME,value='col-sm-12').find_element(by=By.ID,value='resultsUrl').find_element(by=By.TAG_NAME,value='tbody').find_element(by=By.CLASS_NAME,value='odd')
        # startTime = root.find_element(by=By.CLASS_NAME,value='dateFrom').text
        # endTime = root.find_element(by=By.CLASS_NAME,value='dateTo').text
        # captures = root.find_element(by=By.CLASS_NAME,value='captures text-center').text
        # duplicates = root.find_element(by=By.CLASS_NAME,value='dupes text-center').text
        # uniques = root.find_element(by=By.CLASS_NAME,value='uniques text-center').text
        alldata = root.find_elements(by=By.TAG_NAME,value='td')
        startTime = alldata[2]
        endTime = alldata[3]
        captures = alldata[4]
        duplicates = alldata[5]
        uniques = alldata[6]
    except:
        pass
        print("not find content")
    # print(startTime)
    # print(endTime)
    # print(captures)
    # print(duplicates)
    # print(uniques)
    return startTime.text , endTime.text , captures.text,duplicates.text,uniques.text

# getFrequency("https://www.energyhub.com/privacy")
# getFrequency('https://www.allegion.com/corp/en/footer/privacy-statement/tr.html')
def Find(string):
    url = re.findall('https?://(?:[-\w.]|(?:%[\da-fA-F]{2}))+', string)
    return url

def Find_kuohao(string):
    p1 = re.compile(r'[(](.*?)[)]', re.S)
    list1 = re.findall(p1,string)
    # print(list1)
    result = []
    for i in list1:
        index_douhao = i.index(",")
        g = i[:index_douhao]
        result.append(g)
        result = list(set(result))
    return result

print(getFrequency("https://help.abc.net.au/hc/en-us/articles/360001154976-ABC-Privacy-Policy"))
