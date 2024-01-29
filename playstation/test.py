import re
from bs4 import BeautifulSoup

def get_info(soup):
    # 将整个页面转换为字符串
    page_text = str(soup)
    
    # 定义正则表达式模式来匹配 'iarc_' 后跟一或多个数字，然后是 '.png'
    pattern = re.compile(r'iarc_(\d+)\.png')
    
    # 使用 re.search 查找第一个匹配项
    match = re.search(pattern, page_text)
    
    # 如果找到了匹配项，返回数字部分
    if match:
        return match.group(1)  # group(1) 返回第一个捕获组的内容，即数字部分
    
    # 如果没有找到匹配项，返回 None
    return None

# 示例使用
html_content = """
<div>
    <img src="iarc_123.png" alt="Image 1">
    <img src="iarc_456.png" alt="Image 2">
    <img src="other_image.png" alt="Image 3">
</div>
"""

# 创建 BeautifulSoup 对象
soup = BeautifulSoup(html_content, 'lxml')

# 使用函数
number = get_info(soup)
print(number)  # 输出: '123'
