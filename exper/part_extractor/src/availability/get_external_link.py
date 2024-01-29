import os

import requests
from bs4 import BeautifulSoup
import re

def find_external_links(file_path):
    with open(file_path, 'r', encoding='utf-8') as file:
        html_content = file.read()

    soup = BeautifulSoup(html_content, 'html.parser')
    external_links = []

    for link in soup.find_all('a', href=True):
        href = link['href']
        if re.match(r'^https?://', href):
            external_links.append(href)

    return external_links

def check_status_codes(links):
    status_codes = {}

    for link in links:
        try:
            response = requests.get(link)
            status_codes[link] = response.status_code
        except requests.exceptions.RequestException:
            status_codes[link] = 'Error'

    return status_codes

def list_files(directory):
    files = []
    for filename in os.listdir(directory):
        filepath = os.path.join(directory, filename)
        if os.path.isfile(filepath):
            files.append(filepath)
    return files
if __name__ == "__main__":
    folder_path = "./pp_example/"
    files_in_folder = list_files(folder_path)
    for file in files_in_folder:
        if file == "./pp_example/.DS_Store":
            continue
        external_links = find_external_links(file)
        status_codes = check_status_codes(external_links)
        for link, status_code in status_codes.items():
            print(f"Link: {link} - Status Code: {status_code}")
        print(file)

