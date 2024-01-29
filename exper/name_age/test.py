import gensim.downloader as api
from gensim.models import Word2Vec, KeyedVectors

# 下载并加载预训练的word2vec模型
model = api.load("word2vec-google-news-300")

def word_similarity(word1, word2):
    """
    返回两个单词的相似度
    """
    if word1 not in model or word2 not in model:
        return "One or both words are not in the vocabulary."
    return model.similarity(word1, word2)

# 例子
word1 = "king"
word2 = "queen"
print(f"Similarity between {word1} and {word2}: {word_similarity(word1, word2)}")
