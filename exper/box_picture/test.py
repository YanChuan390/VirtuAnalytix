import numpy as np
import pandas as pd
import matplotlib.pyplot as plt

# 设置随机种子以确保可重复性
np.random.seed(0)

# 生成50组随机数据
data = {}
for i in range(50):
    data[f'Sample{i+1}'] = np.random.randn(100) * (i+10) + 50

df = pd.DataFrame(data)

# 使用您的箱线图样式设置
plt.rcParams['axes.facecolor'] = 'honeydew'
plt.rcParams['font.size'] = 14  # 增大字体大小
plt.rcParams['lines.linewidth'] = 2  # 增大线条宽度

# 创建一个5x10的子图网格，并设置整幅图像的宽高比为3:4
fig, axes = plt.subplots(5, 10, figsize=(15, 20), sharey=False)

# 行名称列表
row_names = ["Row1", "Row2", "Row3", "Row4", "Row5"]

# 对于每一列数据，绘制一个箱线图
for i, col in enumerate(df.columns):
    row = i // 10
    col_idx = i % 10
    
    # 为每个子图设置数据范围匹配的刻度线范围
    min_tick = df[col].min() - 5
    max_tick = df[col].max() + 5
    axes[row, col_idx].set_ylim(min_tick, max_tick)
    
    # 使用scatter方法绘制数据点
    median = df[col].median()
    axes[row, col_idx].scatter([1]*len(df[col]), df[col], marker='|', color='k', s=10)
    
    df[[col]].boxplot(ax=axes[row, col_idx], sym='', medianprops={'visible': False})
    axes[row, col_idx].grid(alpha=0.3)
    
    # 每个图只在底部显示其名称
    axes[row, col_idx].set_title('')
    if row == 4:
        axes[row, col_idx].set_xlabel(col)
    else:
        axes[row, col_idx].set_xlabel('')
    
    # 为每行的最左侧添加名称，并调整位置以避免重叠
    if col_idx == 0:
        axes[row, col_idx].annotate(row_names[row], xy=(-0.7, 0.5), xycoords="axes fraction", 
                                    va="center", ha="right", fontsize=14, fontweight="bold")

# 增大行之间的距离
plt.subplots_adjust(hspace=0.5)

plt.tight_layout()
plt.savefig('grid_boxplots_adjusted.pdf', dpi=800, format='pdf')
plt.show()