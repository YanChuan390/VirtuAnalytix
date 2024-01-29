# 统计数量
import os

def read_first_lines_from_directory(directory_path):
    first_lines_set = set()

    it = 0
    # 遍历目录中的所有文件
    for filename in os.listdir(directory_path):
        it += 1
        print(it)
        filepath = os.path.join(directory_path, filename)
        if os.path.isfile(filepath):
            try:
                # 以utf-8格式打开并读取文件的第一行
                with open(filepath, 'r', encoding='utf-8') as file:
                    first_line = file.readline().strip()  # 读取第一行并去除前后的空白字符
                    first_lines_set.add(first_line)  # 添加到set中
            except Exception as e:
                print(f"An error occurred while reading {filename}: {e}")

    # 返回set的长度
    return len(first_lines_set)

if __name__ == "__main__":
    directory_path = "res"
    length = read_first_lines_from_directory(directory_path)
    print(f"The number of unique first lines is: {length}") # 2023.8.30 -> 2620
