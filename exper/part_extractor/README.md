# Quper
## Folder Structure

```
├── README.md
├── LICENSE.md
├── INSTALL.md
├── src
│   ├── compliance of disclosure
│   │	├── compliance_of_disclosure.py
│   │       ├── predict_content.py  
│   │       ├── find_subtitle.py
│   │       ├── bys_classifier.pkl
│   │       ├── bys_tf.pkl
│   │	├── pp_example
│   ├── timeliness
│   │	├── timeline.py
│   ├── availability
├── ├── <!-- External Link -->
│   │   ├── get_external_link.py
├── ├── <!-- Language Type -->
│       ├── get_language_type.py
│   ├── readability
│   │	├── readability.py
│   │	├── doubleNeg_obscure_qualifiers.py
│   │	├── main_idea-location.py
│   │	├── pp_example
├── dataset
│   ├── title.csv
│   ├── language_data_set.xlsx

```
***Note:*** This tree includes only main files. 

## Description:

Below we describe each main file in our folder below.

### src
#### Compliance of disclosure

```compliance of disclosure.py```: Run this file to obtain the full outputs on the console. Filter out privacy policies with unsupported formats and without subheadings. By default, the privacy policy results generated based on the ```pp_example``` folder will be printed. 

```predict_content.py```: Use trained Bayesian classifier(bys_classifier.pkl) as well as a feature vector transformer (bys_tf.pkl) to predict the presence of subtitles in the privacy policy. Please refer to ```predict_content.md``` for details on how to use it.

```find_subtitle.py```: Detect subtitle tags in the privacy policy document. Please refer to ```find_subtitle.md``` for details on how to use it.

```bys_classifier.pkl```: Title Bayesian classifier trained from dataset/title.csv.

```bys_tf.pkl```: Title Bayesian feature vector transformer trained from dataset/title.csv.


<!-- pp_example -->
Some examples of privacy policy documents.  


#### Timeliness

```timeline.py```: Automated test script to get privacy policy web page updates by visiting the waybackmachine website.

#### Availability

```get_external_link.py```: Find all the external links in the html page and check their status codes. Please refer to ```get_external_link.md``` for details on how to use it.

```get_language_type.py```: Automated test script tp get all supported languages in a privacy policy web page. Please refer to ```get_language_type.md``` for details on how to use it.

<!-- pp_example -->
Some examples of privacy policy documents.


#### Readability 
```readability.py```:Calculate the ARI, FRES, LIX, Average Syllables per Word, Average Words per Sentence, Average Letters per Word, Sentence Count, Word Count, Reading Time (minutes), Speaking Time (minutes) of a text.

```doubleNeg_obscure_qualifiers.py```: Find all sentences in the text that are double negatives and those that contain obscure qualifiers.

```main_idea_location.py```: Determine the location of the central idea of the sentence. Please refer to ```main_idea_location.md``` for details on how to use it.

<!-- pp_example -->
Some examples of privacy policy documents.

### dataset
```title.csv``` ---> used by ```bys_classifier.pkl``` and ```bys_tf.pkl``` for Title Bayesian classifier and Title Bayesian feature vector transformer training.
```language_data_set.xlsx``` ---> used by ```get_language_type.py``` for compare with the supported language versions of the acquired skill privacy policy.
