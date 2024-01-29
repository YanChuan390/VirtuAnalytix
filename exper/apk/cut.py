def process_text_file(input_file, output_file):
    with open(input_file, "r") as file:
        lines = file.readlines()

    processed_lines = [line for line in lines if not line.startswith(" " * 8)]
    
    with open(output_file, "w") as output:
        output.writelines(processed_lines)

if __name__ == "__main__":
    input_file_path = "E:\local1/aaa\亚利桑那阳光_ArizonaSunshine_1.6.21896(5.3.x)\亚利桑那阳光_ArizonaSunshine_1.6.21896(5.3.x).txt"  # 替换为你的输入文件路径
    output_file_path = "E:\local1/aaa\亚利桑那阳光_ArizonaSunshine_1.6.21896(5.3.x)\亚利桑那阳光_ArizonaSunshine_1.6.21896(5.3.x)_1.txt"  # 替换为你的输出文件路径
    
    process_text_file(input_file_path, output_file_path)
    
    print(f"处理后的文件保存在: {output_file_path}")
