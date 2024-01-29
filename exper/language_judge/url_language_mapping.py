import sys
import pandas as pd

def get_url_language(csv_path, cols):

    df = pd.read_csv(csv_path)

    def concatenate_row(row):
        re = ''
        for i in cols:
            re += str(row[i])
        return re

    df = df[cols]
    df['concatenated'] = df.apply(concatenate_row, axis=1)
    df = df[['concatenated']]
    return df['concatenated'].tolist()


def get_microsoft_list():
    csv_path = 'D:/pro/py/pycpro1/microsoft/data.csv'
    cols = ['privacy_policy', 'support language', 'Language_supported']
    return get_url_language(csv_path, cols)

def get_oculus_list():
    csv_path = 'D:/pro/py/pycpro1/oculus/csvs/all.csv'
    cols = ['Developer Privacy Policy', 'Languages']
    return get_url_language(csv_path, cols)

def get_pico_list():
    csv_path = 'D:/pro/py/pycpro1/pico/merged.csv'
    cols = ['url', '语言']
    return get_url_language(csv_path, cols)

def get_playstation_list():
    csv_path = 'D:/pro/py/pycpro1/playstation/output.csv'
    cols = ['privacy_policy', 'name']
    return get_url_language(csv_path, cols)

def get_viveport_list():
    csv_path = 'D:/pro/py/pycpro1/viveport/data.csv'
    cols = ['隐私政策', 'language_support']
    return get_url_language(csv_path, cols)


def get_url_language_list():
    ls = []
    for i in [get_microsoft_list(), get_oculus_list(), get_pico_list(), get_playstation_list(), get_viveport_list()]:
        for j in i:
            ls.append(j)
    return ls
