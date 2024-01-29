def contains_japanese(text):
    for char in text:
        # 检查常用日文字符范围
        if '\u3040' <= char <= '\u309F':   # 平假名
            return True
        if '\u30A0' <= char <= '\u30FF':   # 片假名
            return True
        if '\u3400' <= char <= '\u4DBF':   # 扩展A的汉字，包含一些日文汉字
            return True
        if '\u4E00' <= char <= '\u9FFF':   # 常用的汉字，包含一些日文汉字
            return True
        if '\uF900' <= char <= '\uFAFF':   # 兼容性汉字，包含一些日文汉字
            return True

    return False

# 示例
text = "これはテストです。"
print(contains_japanese(text))  # 输出 True