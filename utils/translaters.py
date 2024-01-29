from googletrans import Translator, LANGUAGES
import time

MAX_ATTEMPTS = 3
MAX_CHAR_LIMIT = 4000  # 一个大约的字符限制

def split_text(text, limit=MAX_CHAR_LIMIT):
    """
    分割文本为多个段落，每段落最多有limit个字符。
    """
    words = text.split()
    chunks = []
    chunk = ""

    for word in words:
        if len(chunk) + len(word) <= limit:
            chunk += " " + word
        else:
            chunks.append(chunk.strip())
            chunk = word

    if chunk:
        chunks.append(chunk.strip())

    return chunks

def auto_translate_to_english(text):
    translator = Translator()
    
    # 先检测第一段文本的语言
    first_chunk_language = translator.detect(text.split()[0]).lang
    if first_chunk_language == 'en':
        return text

    # 如果文本长度超过限制，分割文本
    text_chunks = split_text(text) if len(text) > MAX_CHAR_LIMIT else [text]

    translated_chunks = []
    for chunk in text_chunks:
        translation_success = False
        attempts = 0
        while not translation_success and attempts < MAX_ATTEMPTS:
            try:
                # 自动检测语言
                detected_language = translator.detect(chunk).lang

                # 如果文本已经是英文，则直接返回
                if detected_language == 'en':
                    translated_chunks.append(chunk)
                else:
                    translated_text = translator.translate(chunk, src=detected_language, dest='en').text
                    translated_chunks.append(translated_text)

                translation_success = True

            except Exception as e:
                print(f"Error: {e}. Retrying...")
                attempts += 1
                time.sleep(1)  # 等待1秒再重试，以防止过于频繁的请求

    return " ".join(translated_chunks)

if __name__ == "__main__":
    text_to_translate = "由于翻译API可能会有频率限制或其他限制，您可能需要调整MAX_ATTEMPTS和延迟时间，以最大程度地确保成功。以上代码分割文本的方式可能会在句子中断开，这可能会影响翻译的质量。如果您知道文本中的句子边界，那么更好的方式是基于句子边界来分割文本。"

    translated_text = auto_translate_to_english(text_to_translate)
    print(translated_text)