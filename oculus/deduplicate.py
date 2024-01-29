s = set()
with open("app_links_origin.txt", "r") as file:
    for link in file.readlines():
        s.add(link.strip())

with open("app_links.txt", "w") as file:
    for link in s:
        print(link, file=file)
