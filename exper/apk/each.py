import os
from androguard.misc import AnalyzeAPK
from androguard.decompiler.dad import decompile
def add_to_tree(tree, parts):
    current_level = tree
    for part in parts:
        if part not in current_level:
            current_level[part] = {}
        current_level = current_level[part]

def print_tree(tree, indent=""):
    for key, subtree in tree.items():
        print(f"{indent}{key}")
        if subtree:  # 如果还有子树
            print_tree(subtree, indent + "    ")

def process_apk_to_tree(apk_path, output_base_path):
    # 分析 APK
    a, ds, dx = AnalyzeAPK(apk_path)
    
    # 创建一个空的层次结构
    tree = {}

    output_dir_name = os.path.splitext(os.path.basename(apk_path))[0]
    output_dir = os.path.join(output_base_path, output_dir_name)
    os.makedirs(output_dir, exist_ok=True)

    for d in ds:  # 注意这里我们迭代ds，因为它可能是一个DEX列表
        for clazz in d.get_classes():
            # 获取类的全名，并转换为路径结构
            class_name = clazz.get_name()[1:-1]  # 去掉开始的 L 和末尾的 ;
            parts = class_name.split("/")
            parts[-1] += ".java"  # 为最后一个部分添加.java后缀

            add_to_tree(tree, parts)

            # 使用 DAD 反编译器获取 Java 代码
            java_code = clazz.get_source()

            # 创建目录和保存.java文件
            java_file_path = os.path.join(output_dir, *parts)
            os.makedirs(os.path.dirname(java_file_path), exist_ok=True)
            with open(java_file_path, 'w') as f:
                f.write(java_code)

    # 将树结构写入到TXT文件中
    output_txt_path = os.path.join(output_dir, f"{output_dir_name}.txt")
    with open(output_txt_path, 'w') as f:
        original_stdout = os.sys.stdout
        os.sys.stdout = f
        print_tree(tree)
        os.sys.stdout = original_stdout

def main(input_dir, output_base_path):
    # 遍历指定目录下的所有 APK 文件
    ji = 0
    for root, dirs, files in os.walk(input_dir):
        for file in files:
            if file.endswith(".apk"):
                ji += 1
                apk_path = os.path.join(root, file)
                print(apk_path)
                process_apk_to_tree(apk_path, output_base_path)

if __name__ == "__main__":
    input_dir = 'E:/local1/亚利桑那阳光（有com文件夹）'
    output_base_path = 'E:/local1/aaa'
    main(input_dir, output_base_path)
