import os
import sys
import nltk
from nltk.tokenize import sent_tokenize, word_tokenize
from bs4 import BeautifulSoup
nltk.download('punkt')

sys.path.append("d:/pro/py/pycpro1/utils/content_count_and_url_lazy")
from lazy import get_page_source_from_file
from lazy import get_and_save_page_source_once

def calculate_ari(text):
    words = word_tokenize(text)
    sentences = sent_tokenize(text)
    num_characters = sum(len(word) for word in words)
    num_words = len(words)
    num_sentences = len(sentences)
    ari = 4.71 * (num_characters / num_words) + 0.5 * (num_words / num_sentences) - 21.43
    return ari


def calculate_fres(text):
    words = word_tokenize(text)
    sentences = sent_tokenize(text)
    num_words = len(words)
    num_sentences = len(sentences)
    fres = 206.835 - 1.015 * (num_words / num_sentences) - 84.6 * (sum(len(word) for word in words) / num_words)
    return fres


def calculate_lix(text):
    words = word_tokenize(text)
    sentences = sent_tokenize(text)
    num_long_words = len([word for word in words if len(word) > 6])
    num_words = len(words)
    num_sentences = len(sentences)
    lix = (num_words / num_sentences) + (num_long_words * 100 / num_words)
    return lix


def calculate_metrics(text):
    words = word_tokenize(text)
    sentences = sent_tokenize(text)
    num_words = len(words)
    num_sentences = len(sentences)
    num_characters = sum(len(word) for word in words)
    num_syllables = sum([syllable_count(word) for word in words])
    avg_syllables_per_word = num_syllables / num_words
    avg_words_per_sentence = num_words / num_sentences
    avg_letters_per_word = num_characters / num_words
    reading_time = num_words / 200  # Assuming average reading speed of 200 words per minute
    speaking_time = num_words / 150  # Assuming average speaking speed of 150 words per minute
    return avg_syllables_per_word, avg_words_per_sentence, avg_letters_per_word, num_sentences, num_words, reading_time, speaking_time


def syllable_count(word):
    vowels = "aeiouAEIOU"
    count = 0
    in_word = False
    for char in word:
        if char in vowels:
            if not in_word:
                count += 1
                in_word = True
        else:
            in_word = False
    if word.endswith("e"):
        count -= 1
    return count if count > 0 else 1

def list_files(directory):
    files = []
    for filename in os.listdir(directory):
        filepath = os.path.join(directory, filename)
        if os.path.isfile(filepath):
            files.append(filepath)
    return files

def analyze_html_txt_file(page_source):
    soup = BeautifulSoup(page_source, "html.parser")
    text = soup.get_text()
    metrics = {
        "ARI": calculate_ari(text),
        "FRES": calculate_fres(text),
        "LIX": calculate_lix(text)
    }
    avg_syllables_per_word, avg_words_per_sentence, avg_letters_per_word, num_sentences, num_words, reading_time, speaking_time = calculate_metrics(text)
    metrics["Average Syllables per Word"] = avg_syllables_per_word
    metrics["Average Words per Sentence"] = avg_words_per_sentence
    metrics["Average Letters per Word"] = avg_letters_per_word
    metrics["Sentence Count"] = num_sentences
    metrics["Word Count"] = num_words
    metrics["Reading Time (minutes)"] = reading_time
    metrics["Speaking Time (minutes)"] = speaking_time
    return metrics

def analyze_url(url):
    return analyze_html_txt_file(get_and_save_page_source_once(url))

if __name__ == "__main__":
    folder_path = "./pp_example/"
    files_in_folder = list_files(folder_path)
    for file in files_in_folder:
        if file == "./pp_example/.DS_Store":
            continue
        with open(file, "r", encoding="utf-8") as file:
            html_content = file.read()
        print(analyze_html_txt_file(html_content))

if __name__ == "__main__xxx":
    folder_path = "./pp_example/"
    files_in_folder = list_files(folder_path)
    for file in files_in_folder:
        if file == "./pp_example/.DS_Store":
            continue
        with open(file, "r", encoding="utf-8") as file:
            html_content = file.read()
        soup = BeautifulSoup(html_content, "html.parser")
        text = soup.get_text()
        print(len(text))
        ari = calculate_ari(text)
        fres = calculate_fres(text)
        lix = calculate_lix(text)
        avg_syllables_per_word, avg_words_per_sentence, avg_letters_per_word, num_sentences, num_words, reading_time, speaking_time = calculate_metrics(
            text)
        print(file)
        print("ARI:", ari)
        print("FRES:", fres)
        print("LIX:", lix)
        print("Average Syllables per Word:", avg_syllables_per_word)
        print("Average Words per Sentence:", avg_words_per_sentence)
        print("Average Letters per Word:", avg_letters_per_word)
        print("Sentence Count:", num_sentences)
        print("Word Count:", num_words)
        print("Reading Time (minutes):", reading_time)
        print("Speaking Time (minutes):", speaking_time)
        print("---------------------------")