import threading
from queue import Queue
from count import scrape_and_save_game_info
from count import get_id_from_url
import os

THREAD_NUM = 10
APP_LINKS_FILE = "links/app_links.txt"

def worker():
    while True:
        url = url_queue.get()
        if url is None:
            break

        id = get_id_from_url(url) # 检查文件是否已存在
        file_name = f"game_info_{id}.csv"
        if os.path.exists(file_name):
            print(f"文件已存在，跳过处理：{url}")
            url_queue.task_done()
            continue

        scrape_and_save_game_info(url)

        url_queue.task_done()

def main():
    global url_queue
    url_queue = Queue()

    # 创建工作线程
    threads = []
    for _ in range(THREAD_NUM):
        t = threading.Thread(target=worker)
        t.start()
        threads.append(t)

    # 读取链接并放入队列
    with open(APP_LINKS_FILE, "r") as file:
        for line in file:
            url = line.strip()
            url_queue.put(url)

    # 等待所有任务完成
    url_queue.join()

    # 停止工作线程
    for _ in range(THREAD_NUM):
        url_queue.put(None)
    for t in threads:
        t.join()

if __name__ == '__main__':
    main()
    main()