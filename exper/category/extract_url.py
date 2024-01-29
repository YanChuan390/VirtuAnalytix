import pandas as pd

def save_privacy_urls_to_txt(input_csv, output_txt):
    # 1. 读取CSV文件
    df = pd.read_csv(input_csv)
    
    # 2. 过滤出长度大于5的URLs
    valid_urls = df["privacy_url"][df["privacy_url"].str.len() > 9]
    
    # 3. 将这些有效的URLs写入到txt文件中
    valid_urls.to_csv(output_txt, index=False, header=False)

# 使用函数
save_privacy_urls_to_txt("processed_merged_platform_data.csv", "privacy_urls.txt")
