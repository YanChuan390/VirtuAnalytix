import pandas as pd
import re
csv_path = 'D:/pro/py/pycpro1/playstation/output.csv'

df = pd.read_csv(csv_path)

df = df[['name']]

st = set()
for idx, row in enumerate(df.itertuples()):
    if pd.isnull(row[1]):
        continue

    s = row[1]
    s0 = s
    p = -1
    for i in range(len(s)):
        if s[i] == '(':
            p = i
            break
        
    if p == -1:
        continue

    s = s[p : ]
    # print(s0, "||||||", s)

    for i in re.split('[ ,()!+/]', s):
        st.add(i)

for i in st:
    print(i)
