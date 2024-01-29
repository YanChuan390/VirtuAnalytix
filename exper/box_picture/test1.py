
import pandas as pd
import math

df = pd.read_csv('D:/pro/py/pycpro1/exper/compliance_readability/compliance_readability.csv')

# 只保留第一列和最后10列
df = df.iloc[:, list(range(1)) + list(range(-10, 0))]

print(df.head())  # 打印前几行以确认更改

# 按照第一列进行分组
grouped = df.groupby(df.columns[0])

# 打印每个组的第一列的名称
for name, group in grouped:
    print(name)  # 打印组名

# 初始化一个5*10的空列表
data = [[] for _ in range(5)]

# 对每个组的每一列数据进行检查
for name, group in enumerate(grouped):
    print(group[1])
    for col in group[1].columns[1:]:  # 跳过第一列，因为它是分组列
        print(col)
        col_data = group[1][col]
        def convert_to_float(value):
            return float(value)
        valid_data = [convert_to_float(x) for x in col_data if not math.isnan(x)]
        data[name].append(valid_data)
    
# 打印结果以确认
for i in range(5):
    for j in range(10):
        print(f"Group {i+1}, Column {j+1}: {len(data[i][j])} valid numbers")


import numpy as np
import matplotlib.pyplot as plt

def create_boxplot(data, ax, xlabel_name='Boxplot of Data', y_lim=None):
    # 使用箱线图样式设置
    plt.rcParams['axes.facecolor'] = 'honeydew'
    plt.rcParams['font.size'] = 14  # 增大字体大小
    plt.rcParams['lines.linewidth'] = 5  # 增大线条宽度

    # 计算IQR和须的范围
    Q1 = np.percentile(data, 25)
    Q3 = np.percentile(data, 75)
    IQR = Q3 - Q1
    lower_bound = Q1 - 1.5 * IQR
    upper_bound = Q3 + 1.5 * IQR

    # 使用布尔索引过滤掉异常值
    data_array = np.array(data)
    filtered_data = data_array[(data_array >= lower_bound) & (data_array <= upper_bound)]

    # 使用scatter方法绘制非异常值的数据点
    ax.scatter([1] * len(filtered_data), filtered_data, marker='.', color='k', s=10)

    # 使用计算出的五个指标绘制箱线图
    mid = (61/255, 175/255, 64/255)
    cc = (51/255, 161/255, 211/255)
    ax.boxplot([data], positions=[1], sym='', 
       boxprops=dict(color=cc, linewidth=4),
       medianprops=dict(color=mid, linewidth=7),
       whiskerprops=dict(color=cc, linestyle='-', linewidth=1),
       capprops=dict(color=cc, linewidth=4))
           
    ax.grid(alpha=0.3)

    # 设置x轴标签名称
    ax.set_xlabel(xlabel_name)
    ax.set_xlabel(xlabel_name, fontsize=18, fontweight='bold')
    ax.xaxis.labelpad = 20


    # 隐藏底部坐标
    ax.set_xticks([])

    # 设置y轴的范围
    if y_lim:
        ax.set_ylim(y_lim)
    ax.tick_params(axis='y', labelsize=18)

column_names = [
    "ARI (Automated\nReadability Index)",
    "FRES (Flesch\nReadability\nEase Score)",
    "LIX (Laesbarheds\nIndex)",
    "LPW (Letters\nper Word)",
    "RT (Reading\nTime/s)",
    "ST (Speaking\nTime/s)",
    "SPW (Syllables\nper Word)",
    "WPS (Words\nper Sentence)",
    "SC (Sentence\nCount)",
    "WC (Word Count)"
]

fig, axes = plt.subplots(5, 10, figsize=(30, 35))  # 5行10列的图

group_names = [name for name, _ in grouped]  # 获取所有组名
print(group_names)
group_names = ['Microsoft', 'Oculus', 'Pico', 'PlayStation', 'Viveport']
print(group_names)

row_ratio = (1 - 0.018) / 5

x_coord = .5

print(group_names)
for i in range(5):

    group_name = group_names[i]
    # 为了确定y坐标，我们从1开始减去i * row_ratio
    y_coord = 1 - (i * row_ratio) - .04 + .01
    fig.text(x_coord, y_coord, group_name, fontsize=30, ha='center', va='top', fontweight='bold', fontname='Times New Roman')

    for j in range(10):
        create_boxplot(data[i][j], axes[i, j], xlabel_name=column_names[j])

for ax in axes.flat:
    ax.set_title(ax.get_title(), fontsize=14, fontweight='bold')
    
plt.tight_layout()
# plt.subplots_adjust(hspace=3.0)

# plt.subplots_adjust(left=0.1, right=0.95, bottom=0.05, top=0.95, hspace=0.8)
plt.subplots_adjust(left=0.04, right=0.97, bottom=0.05, top=0.95, hspace=0.8)
plt.savefig('output.pdf')
plt.show()
