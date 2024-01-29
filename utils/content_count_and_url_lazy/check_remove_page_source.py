# 路径p1 = d:\pro\py\pycpro1\url_lazy\page_sources，包含大量的txt文件
# 每个txt文件存储了某网页的page_source
# 使用beautiful读取该page_source文件
# 然后把所有元素的.text属性读取到
# 存到一个str中
# 如果该str的长度<10
# 则删除该txt文件

import os
import re
from bs4 import BeautifulSoup
import sys

def check_and_remove():
    # 遍历p1下的所有txt文件
    p1 = "d:/pro/py/pycpro1/utils/content_count_and_url_lazy/page_sources"

    for root, dirs, files in os.walk(p1):
        for f in files:
            if f.endswith(".txt"):
                # 判断该txt文件大小是否大于10kb
                if os.path.getsize(os.path.join(root, f)) > 10 * 1024:
                    continue

                # 读取该txt文件
                fp = open(os.path.join(root, f), "r", encoding="utf-8")
                page_source = fp.read()
                fp.close()

                # 使用beautiful读取该page_source文件
                soup = BeautifulSoup(page_source, "html.parser")

                # 然后把所有元素的.text属性读取到
                # 存到一个str中
                s = ""
                for e in soup.descendants:
                    if e.string != None:
                        s += e.string.strip()

                # 如果该str的长度<10
                # 则删除该txt文件
                if len(s) < 10 or "connect error or disconnect" in s:
                    if (len(s)):
                        print(f"cur: {s}")
                    os.remove(os.path.join(root, f))
                    print("删除了", os.path.join(root, f))

if __name__ == "__main__":
    check_and_remove()