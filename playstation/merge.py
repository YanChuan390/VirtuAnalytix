import os
import csv
fd_path = os.path.join(".", "res")

def R(p):
    lines = []
    with open(p, 'r', encoding='utf-8') as f:
        for i in f.readlines():
            lines.append(i)
    return lines

def f(s):
    parts = s.split(' ', 1)
    if len(parts) == 1:
        return parts[0], ''
    else:
        return parts[0], parts[1]

u = []
for root, dirs, files in os.walk(fd_path):
    for file in files:
        # print(file)
        if file.endswith('.txt'):
            lines = R(os.path.join(root, file))
            if len(lines) == 4:
                z = []
                for i in lines:
                    pt = f(i)
                    se = pt[1].strip()
                    z.append("null" if se == "..." else se)
                u.append(z)

have = 0
for i in range(len(u)):
    u[i][0] = int(u[i][0])
    si = u[i][3]
    if "https://store.playstation.com/en-sg/product" in si:
        u[i][3] = "null"
    if u[i][3] != "null":
        have += 1
print(have)
        
    
with open('data.csv','w', encoding='utf-8') as f:
    writer = csv.writer(f)
    writer.writerow(["id", "name", "info", "privacy_policy"])
    writer.writerows(u)