import os

import nltk
from nltk.tokenize import sent_tokenize, word_tokenize
from bs4 import BeautifulSoup
import re


def count_double_negatives(text):
    sentences = sent_tokenize(text)
    double_negatives_count = 0

    for sentence in sentences:
        if has_double_negatives(sentence):
            double_negatives_count += 1

    return double_negatives_count


def has_double_negatives(sentence):
    # Match double negatives pattern
    pattern = r"\b(?:not|n't|never|no)\s+\b(?:\w+\s+)?(?:not|n't|never|no)\b"
    return re.search(pattern, sentence, re.I) is not None


def count_obscure_language_qualifiers(text):
    sentences = sent_tokenize(text)
    obscure_qualifiers_count = 0
    obscure_words = ["possibly", "perhaps", "maybe", "might", "could", "potentially","may"]

    for sentence in sentences:
        if has_obscure_qualifiers(sentence, obscure_words):
            obscure_qualifiers_count += 1

    return obscure_qualifiers_count


def has_obscure_qualifiers(sentence, obscure_words):
    words = nltk.word_tokenize(sentence.lower())
    return any(word in obscure_words for word in words)

def list_files(directory):
    files = []
    for filename in os.listdir(directory):
        filepath = os.path.join(directory, filename)
        if os.path.isfile(filepath):
            files.append(filepath)
    return files

if __name__ == "__main__":
    folder_path = "./pp_example/"
    files_in_folder = list_files(folder_path)
    for file in files_in_folder:
        if file == "./pp_example/.DS_Store":
            continue
        with open(file, "r", encoding="utf-8") as file:
            html_content = file.read()

        soup = BeautifulSoup(html_content, "html.parser")
        text = soup.get_text()

        double_negatives_count = count_double_negatives(text)
        obscure_qualifiers_count = count_obscure_language_qualifiers(text)
        print(file)
        print("Double Negatives Count:", double_negatives_count)
        print("Obscure Language Qualifiers Count:", obscure_qualifiers_count)
        print("------------------")
