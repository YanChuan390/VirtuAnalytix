import sys
import random
import matplotlib.pyplot as plt
import numpy as np
import pandas as pd
import seaborn as sns
from for_heatmap import for_heatmap
from matplotlib.colors import LinearSegmentedColormap, LogNorm
from matplotlib.ticker import FuncFormatter

row_labels, col_labels, cnt, cnt_true = for_heatmap()

if 1: # fill map_to, such 'steam.txt' -> 'Steam', 'en' -> 'English'
    map_to = dict()
    pname_list = ['microsoft.txt', 'oculus.txt', 'pico.txt', 'playstation.txt', 'viveport.txt']
    pname_list_to = ['Microsoft', 'Oculus', 'Pico', 'PlayStation', 'Viveport']
    language_list = ['en', 'zh', 'ja', 'de', 'et', 'vi', 'fr', 'no', 'other']
    language_list_to = ['English', 'Chinese', 'Japanese', 'German', 'Estonian', 'Vietnamese', 'French', 'Norwegian', 'Others']

    for i in range(len(pname_list)):
        map_to[pname_list[i]] = pname_list_to[i]
    for i in range(len(language_list)):
        map_to[language_list[i]] = language_list_to[i]
    for i in range(len(row_labels)):
        row_labels[i] = map_to[row_labels[i]]
    for i in range(len(col_labels)):
        col_labels[i] = map_to[col_labels[i]]

    print(row_labels)
    print(col_labels)

# for i in range(len(cnt)):
#     for j in range(len(cnt[i])):
#         cnt[i][j] += 1

platform_country = { 'Microsoft': 'USA', 'Oculus': 'USA', 'Pico': 'China', 
                'PlayStation': 'Japan', 'Steam': 'USA', 'Viveport': 'Taiwan'}


if 1: # rename row_labels to 'platform \n country'
    # platform_pp_ratios = data.sum(axis=1) / data.sum()
    new_row_labels = []
    for idx, label in enumerate(row_labels):
        country = platform_country.get(label, "")
        # pp_ratio = platform_pp_ratios[idx]
        # new_label = f"{label}\n{country}, {pp_ratio:.1%}"
        # new_label = f"{label}\n{country}"
        new_label = f"{label}"
        new_row_labels.append(new_label)
    row_labels = new_row_labels

data = np.array(cnt)
data_true = np.array(cnt_true)

# df_log 用于控制热力图的颜色
df_log = pd.DataFrame(np.log2(data + 1), index=row_labels, columns=col_labels)

# df_annot是热力图格子上的文本
df_annot = pd.DataFrame(data, index=row_labels, columns=col_labels).astype(str)

for i in range(len(row_labels)):
    for j in range(len(col_labels)):
        num = data[i][j]
        num_true = data_true[i][j]
        num_ratio = num_true / num if num > 0 else -1.0
        s1 = str(num)
        s2 = str(num_true)
        s3 = ''
        if num == 0:
            s3 = '-'
        elif num_true == 0:
            s3 = '0%'
        else:
            s3 = f"{num_ratio * 100:.1f}%"
        df_annot.at[row_labels[i], col_labels[j]] = f"{s1}\n{s2}\n{s3}"

plt.rcParams['font.family'] = 'Times New Roman'
plt.rcParams['font.weight'] = 'bold'
plt.rcParams['font.size'] = 20  # 设置字体大小
plt.rcParams['xtick.labelsize'] = 18  # x轴刻度的字体大小
plt.rcParams['ytick.labelsize'] = 18  # y轴刻度的字体大小

colors = [
    (253/255, 253/255, 228/255),
    (158/255, 218/255, 175/255),
    (37/255, 173/255, 188/255),
    (10/255, 36/255, 99/255)
]

custom_cmap = LinearSegmentedColormap.from_list("custom_cmap", colors, N=256)

fig, ax = plt.subplots(dpi=200, figsize=(10, 12))

cax = sns.heatmap(df_log, 
                  annot=df_annot, 
                  vmax=np.log2(1000), vmin=0, # 这个是控制颜色的数值范围
                  xticklabels=True, yticklabels=True,
                  square=True, # 格子是方形的
                  cmap=custom_cmap, # 自定义的颜色映射
                  linewidths=5, linecolor='white',  # 格子间的线条宽度和颜色。
                  cbar_kws={"norm": LogNorm()}, # 对颜色条的设置
                  fmt='s', # annot[i][j] -> fmt(annot[i][j])
                  ax=ax,
                  annot_kws={"size": 16}, # 设置注释文字的大小为16
                  cbar=False)  # 注意这里cbar = False

cax.set_xticklabels(cax.get_xticklabels(), rotation=16)

# 右侧条的位置大小: x, y, width, height
cbar_ax = cax.figure.add_axes([.91, .2967, .03, .397])  
cbar = cax.figure.colorbar(cax.collections[0], cax=cbar_ax, norm=LogNorm())
def fmt(x, pos):
    return r'$2^{{{}}}$ = {}'.format(int(np.round(x)), int(np.exp2(x)))
cbar.formatter = FuncFormatter(fmt)
cbar.update_ticks()
cbar.ax.tick_params(labelsize=16)

plt.title('', fontdict={'fontsize': 20, 'fontweight': 'bold'})
plt.tick_params(axis='x', bottom=False, top=True, labelbottom=True, labeltop=False)

cax.yaxis.set_ticks_position('none')  # 移除y轴上的刻度线
cax.xaxis.set_ticks_position('none')  # 移除y轴上的刻度线
cbar.ax.tick_params(labelsize=16)

description = '''
Each cell contains three rows of numbers. The 1-st row indicates the number of privacy policy 
documents in the corresponding language for the VR app platform. The 2-nd row shows how 
many of these policies in 1-st row are in the same language as the language displayed in 
the app description page. The 3-rd row represents the ratio between these two numbers.'''

fig.text(0.5, 0.15, description, ha='center', va='bottom', fontsize=17)

plt.savefig("heatmap.pdf", format='pdf', dpi=200, bbox_inches='tight')
# plt.show()
