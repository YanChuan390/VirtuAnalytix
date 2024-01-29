'''
读取每行的url
输出url+en, hash_code
'''
def process_urls():
    urls = []
    with open("origin_urls.txt", "r", encoding="utf-8") as f:
        for url in f.readlines():
            url = url.strip() + "?hl=en-us&gl=us"
            urls.append(url)
    
    with open("urls.txt", "w", encoding="utf-8") as f:
        for url in urls:
            f.write(url + "\n")

process_urls()