import pandas as pd
import re
csv_path = 'D:/pro/py/pycpro1/oculus/csvs/all.csv'

df = pd.read_csv(csv_path)

print(df.info)
print(df.columns)

print('====================')

df = df[['Languages']]

s = set()
for idx, row in enumerate(df.itertuples()):
    if pd.isnull(row[1]):
        continue

    for i in re.split('[ ,()!+]', row[1]):
        s.add(i)

for i in s:
    print(i)
