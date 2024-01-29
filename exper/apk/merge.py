import os

def find_java_files(folder_path):
    java_files = []
    for root, dirs, files in os.walk(folder_path):
        for file in files:
            if file.endswith(".java"):
                java_files.append(os.path.join(root, file))
    return java_files

def merge_java_files(java_files, output_path):
    merged_content = ""
    for java_file in java_files:
        with open(java_file, "r") as file:
            content = file.read()
            merged_content += content + "\n\n"  # 在文件之间添加一些空行
    
    with open(output_path, "w") as output_file:
        output_file.write(merged_content)

if __name__ == "__main__":
    folder_path = "E:/local1/aaa/亚利桑那阳光_ArizonaSunshine_1.6.21896(5.3.x)"
    output_file_path = os.path.join(folder_path, "aaamerge.txt")
    
    java_files = find_java_files(folder_path)
    merge_java_files(java_files, output_file_path)
    
    print(f"合并文件保存在: {output_file_path}")
