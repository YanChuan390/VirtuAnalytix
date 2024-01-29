from bs4 import BeautifulSoup
import sys
import os

sys.path.append("D:/pro/py/pycpro1/url_lazy")
from main import get_and_save_page_source
from main import get_page_source_from_file
from main import check_is_saved
from main import get_and_save_page_source_once
from main import delete_local_file_of_url 
from main import generate_filename

def part_top(page_source):
    # id: appHubAppName, 获取其text
    # element's class: game_description_snippet 递归获取该元素的所有子级的text
    # id: userReviews, 获取其text
    # class: glance_tags_ctn popular_tags_ctn 递归获取该元素的所有子级的text
    pass
    try:
        soup = BeautifulSoup(page_source, 'html.parser')
    except Exception as e:
        print(f"Error initializing BeautifulSoup: {e}")
        return "-1"
    
    try:
        app_name = soup.find(id='appHubAppName').text
    except Exception as e:
        print(f"Error fetching app name: {e}")
        app_name = 'Not found'
        
    try:
        game_desc = ' '.join(soup.find(class_='game_description_snippet').stripped_strings)
    except Exception as e:
        print(f"Error fetching game description: {e}")
        game_desc = 'Not found'
        
    try:
        user_reviews = ' '.join(soup.find(id='userReviews').stripped_strings)
    except Exception as e:
        print(f"Error fetching user reviews: {e}")
        user_reviews = 'Not found'
    
    try:
        popular_tags = ' '.join(soup.find(class_='glance_tags_ctn popular_tags_ctn').stripped_strings)
    except Exception as e:
        print(f"Error fetching popular tags: {e}")
        popular_tags = 'Not found'
        
    return {
        'app_name': app_name,
        'game_description': game_desc,
        'user_reviews': user_reviews,
        'popular_tags': popular_tags
    }

def part_bottom(page_source):
#     # id: genresAndManufacturer, 递归获取其所有子级元素的text
    try:
        soup = BeautifulSoup(page_source, 'html.parser')
    except Exception as e:
        print(f"Error initializing BeautifulSoup: {e}")
        return "-1"
    
    try:
        genres_and_manufacturer_text = ' '.join(soup.find(id='genresAndManufacturer').stripped_strings)
    except Exception as e:
        print(f"Error fetching genres and manufacturer: {e}")
        genres_and_manufacturer_text = 'Not found'
        
    return {
        'genres_and_manufacturer': genres_and_manufacturer_text
    }

def part_tag(page_source):
    # class: game_area_features_list_ctn, 获取其所有子级元素的text(忽略等0或者none的text)
    try:
        soup = BeautifulSoup(page_source, 'html.parser')
    except Exception as e:
        print(f"Error initializing BeautifulSoup: {e}")
        return "-1" 

    try:
        tag_elements = soup.find(class_='game_area_features_list_ctn').find_all(['div', 'a'])
        tags = [tag.text.strip() for tag in tag_elements if tag.text.strip() not in ('', 'none')]
    except Exception as e:
        print(f"Error fetching game tags: {e}")
        tags = ['-1']

    return {
        'game_tags': tags
    }

def part_language(page_source):
    # 找到class为game_language_options的<table>标签记为f
    # 然后找到f的子级元素<tbody>记为x
    # 然后对于x的每个子级元素tr
    # 如果该tr的class不是class="unsupported"
    # 则把该tr的所有子级元素son的text放到一个列表中list_of_tri = [text1, text2, ...], 注意，如果son没有text属性，或者length==0，则其text为"0"
    # 最后整合到一个list中list_all = [list_of_tr0, list_of_tr1, ...]
    try:
        soup = BeautifulSoup(page_source, 'html.parser')
    except Exception as e:
        print(f"Error initializing BeautifulSoup: {e}")
        return "-1"

    try:
        table = soup.find(class_='game_language_options')
        tbody = table.find('tbody')
        tr_elements = tbody.find_all('tr')

        languages = []
        for tr in tr_elements:
            if tr.get('class') != ['unsupported']:
                son_elements = tr.find_all(True, recursive=False)  # Find all direct child elements of tr
                language_info = [son.text.strip() if son.text and son.text.strip() else "0" for son in son_elements]
                languages.append(language_info)

    except Exception as e:
        print(f"Error fetching game languages: {e}")
        languages = ['-1']

    return {
        'game_languages': languages
    }

def test():
    pass
    # urls = []
    # urls.append("https://store.steampowered.com/app/577530/Pixel_Ripped_1989/")
    # urls.append("https://store.steampowered.com/app/1053760/Arkio/")
    # urls.append("https://store.steampowered.com/app/1704080/Bean_Stalker/")
    # urls.append("https://store.steampowered.com/app/1620410/Federation77/")
    # urls.append("https://store.steampowered.com/app/1465070/Legendary_Tales/")
    # delete_local_file_of_url("https://store.steampowered.com/app/1620410/Federation77/")
    # for i in urls:
    #     print(f"current url: {i}")
    #     tu = i
    #     ps = get_and_save_page_source_once(tu)
    #     print("len: ", len(ps))
    #     print(part_top(ps))
    #     print(part_bottom(ps))
    #     print(part_tag(ps))
    #     print(part_language(ps))
    #     process_1_2_3/result123.txt

def main():
    urls = []
    with open("d:\pro\py\pycpro1\steam\process_1_2_3/result123.txt", "r", encoding="utf-8") as f:
        for i in f.readlines():
            j = i.strip().split("|||")[0].strip()
            urls.append(j)

    save_folder = "./gameinfo"

    for i in urls:
        filename = generate_filename(i)
        save_path = os.path.join(save_folder, filename)
        def here():
            with open(save_path, "a", encoding="utf-8") as f:
                ps = get_and_save_page_source_once(i)
                p_top = part_top(ps)
                p_bottom = part_bottom(ps)
                p_tag = part_tag(ps)
                p_language = part_language(ps)
                print(p_top, file=f)
                print(p_bottom, file=f)
                print(p_tag, file=f)
                print(p_language, file=f)
        here()
        redo = False 
        # 判断f的内容中是否含有-1
        with open(save_path, "r", encoding="utf-8") as f:
            if "-1" in f.read() or "Not" in f.read():
                redo = True
        if redo:
            delete_local_file_of_url(i)
            here()

from concurrent.futures import ThreadPoolExecutor

def process_url(url):
    filename = generate_filename(url)
    save_path = os.path.join("./game_info", filename)
    print(save_path, "\n")
    
    with open(save_path, "a", encoding="utf-8") as f:
        ps = get_and_save_page_source_once(url)
        
        p_top = part_top(ps)
        p_bottom = part_bottom(ps)
        p_tag = part_tag(ps)
        p_language = part_language(ps)
        
        print(p_top, file=f)
        print(p_bottom, file=f)
        print(p_tag, file=f)
        print(p_language, file=f)

def main_parallel():
    urls = []
    with open("d:/pro/py/pycpro1/steam/process_1_2_3/result123.txt", "r", encoding="utf-8") as f:
        for i in f.readlines():
            j = i.strip().split("|||")[0].strip()
            urls.append(j)
    
    with ThreadPoolExecutor(max_workers=8) as executor:
        executor.map(process_url, urls)

if __name__ == "__main__":
    main_parallel()