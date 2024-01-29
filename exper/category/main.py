import pandas as pd

platform_infolist = [
    ["microsoft", "d:/pro/py/pycpro1/microsoft/data.csv", ["name"], ["Age_rating", "age_info"], ["category", "Category"], ["privacy_policy"]],
    ["oculus", "d:/pro/py/pycpro1/oculus/csvs/all.csv", ["game_name"], ["game_age"], ["Genres"], ["Developer Privacy Policy"]],
    ["pico", "d:/pro/py/pycpro1/pico/merged.csv", ["name"], ["年龄"], ["标签"], ["url"]],
    ["playstation", "d:/pro/py/pycpro1/playstation/output.csv", ["name"], ["age"], ["genre"], ["privacy_policy"]],
    ["viveport", "d:/pro/py/pycpro1/viveport/data.csv", ["name"], ["内容分级"], ["genres"], ["隐私政策"]]
]

def concatenate_columns(df, columns):
    concat_series = df[columns[0]].astype(str)
    for col in columns[1:]:
        if col in df:
            concat_series = concat_series + " " + df[col].astype(str)
    return concat_series

def read_platform_data(platform_data):
    platform_name, filepath, name_cols, age_cols, category_cols, privacy_cols = platform_data
    df = pd.read_csv(filepath)
    
    df["name"] = concatenate_columns(df, name_cols)
    df["age"] = concatenate_columns(df, age_cols)
    df["category"] = concatenate_columns(df, category_cols)
    df["privacy_url"] = concatenate_columns(df, privacy_cols)
    
    df["platform"] = platform_name
    return df[["platform", "name", "age", "category", "privacy_url"]]

all_platforms_df = pd.concat([read_platform_data(data) for data in platform_infolist])

# 处理merged_platform_data.csv
def process_dataframe(df):
    # 对于microsoft的category列的每一项内容x，如果x是以"wxty"卡头的，对其取x = x.split("|||")[1]，否则x = x.split(" ")[0]
    mask_microsoft = df['platform'] == 'microsoft'
    df.loc[mask_microsoft, 'category'] = df.loc[mask_microsoft, 'category'].apply(lambda x: x.split('|||')[1] if '. Cate' in x else x.split(' ')[0])
    df.loc[mask_microsoft, 'category'] = df.loc[mask_microsoft, 'category'].apply(lambda x: x.split(' ')[0])

    # 对于oculus的privacy_url列的每一项内容x, 令x = x.split(" ")[-1]
    mask_oculus = df['platform'] == 'oculus'
    df.loc[mask_oculus, 'privacy_url'] = df.loc[mask_oculus, 'privacy_url'].apply(lambda x: x.split(' ')[-1])
    df.loc[mask_oculus, 'category'] = df.loc[mask_oculus, 'category'].apply(lambda x: x.split(' ')[1] if x.startswith(",") else x)

    # 对于pico的category列，去掉x的前三个汉字, 然后令x = x.split(" ")[0]
    mask_pico = df['platform'] == 'pico'
    df.loc[mask_pico, 'category'] = df.loc[mask_pico, 'category'].apply(lambda x: x[3:].split(' ')[0])

    # 对于playstation和viveport 的category列，令x = x.split(" ")[0]
    for platform in ['playstation', 'viveport']:
        mask = df['platform'] == platform
        df.loc[mask, 'category'] = df.loc[mask, 'category'].apply(lambda x: x.split(' ')[0])
        
    return df

processed_df = process_dataframe(all_platforms_df)
processed_df.to_csv("processed_merged_platform_data.csv", index=False)
