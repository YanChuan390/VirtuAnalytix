import pandas as pd
import re
csv_path = 'D:/pro/py/pycpro1/viveport/data.csv'

df = pd.read_csv(csv_path)

df = df[['language_support']]

st = set()
for idx, row in enumerate(df.itertuples()):
    if pd.isnull(row[1]):
        continue

    for i in re.split('[ ,()!+/^]', row[1]):
        st.add(i)

for i in st:
    print(i)
