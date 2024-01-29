import pandas as pd
import matplotlib.pyplot as plt
import numpy as np

def generate_data(num_samples=1000):
    """生成模拟数据"""
    return np.random.uniform(5, 20, num_samples)

def plot_box_chart(data, filename):
    """绘制箱线图并保存为PDF"""
    df = pd.DataFrame(data)
    plt.rcParams['axes.facecolor'] = 'honeydew'
    df.plot.box(sym='|', fontsize=15)
    plt.grid(alpha=0.3)
    plt.savefig(filename, dpi=800, format='pdf')
    plt.show()

# 生成模拟数据
num_samples = 1000
data = {
    'FKG': generate_data(num_samples),
    'GFI': generate_data(num_samples),
    'CLI': generate_data(num_samples),
    'SMOG': generate_data(num_samples)
}

# 绘制箱线图
plot_box_chart(data, 'rm1.pdf')
