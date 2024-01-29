import pandas as pd
csv_path = 'D:/pro/py/pycpro1/microsoft/data.csv'

df = pd.read_csv(csv_path)

print(df.info)
print(df.columns)

df1 = df[['support language']]

df2 = df[['Language_supported']]

df1.columns = df2.columns = ['lan']

df_combined = pd.concat([df1, df2])

# df_combined.to_csv('temp.csv', index = False)

print("===============")

s = set()
for idx, row in enumerate(df_combined.itertuples()):
    for i in row[1].split('|||'):
        if 'following languages' not in i:
            s.add(i)

for i in s:
    print(i)
