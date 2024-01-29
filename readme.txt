project/
│
├── microsoft/              # Data Collection on the Microsoft
├── oculus/                 # Data Collection on the Oculus
├── pico/                   # Data Collection on the Pico
├── playstation/            # Data Collection on the PlayStation
├── steam/                  # Data Collection on the Steam
├── viveport/               # Data Collection on the Viveport
│
├── exper/                                                  
│   ├── apk/                        # AndroidMainfest.xml Analyse                                           
│   ├── box_picture/                # Draw Box Picture                         
│   ├── category/                   # Category Classification                             
│   ├── compliance_readability/     # Compliance and Readability Analyse                                   
│   ├── count_all/                  # Merge all csvs and count
│   ├── game_name/                  # Game Name Collection
│   ├── is_valid/                   # Check if the Privacy Policy url is valid
│   ├── language_judge/             # Privacy Policy Language Analyse
│   ├── name_age/                   # Privacy Policy age compliance analyse
│   └── part_extractor/             # Analyse Functions from the previous Paper: Skipper
│
├── reverse engineering/            # Reverse Engineering of the VR Headsets                             
│   ├── Oculus Reverse Engineering/ # Reverse Engineering of the Oculus (Unity & Unreal)
│   ├── Pico Reverse Engineering/   # Reverse Engineering of the Pico (Unity & Unreal)
│   └── field_offset_search.cs      # Field Offset Search
│                                       
└── utils/                                         
    ├── content_count_and_url_lazy/                 # Save The PageSource For all the visisted urls
    ├── extract_pdf_content.py                      # Extract the content from the pdf
    ├── file_deduplicate.py                         # Deduplicate the files 
    ├── get_privacy_policy_urls_from_csvs_folder/   # Privacy Policy urls Processing          
    ├── merge_csv.py                                # Merge csvs         
    ├── pdf_lazy/                                   # Save the .pdf for privacy policy urls
    └── translaters.py                              # Translate the Privacy Policy


###PART1.###
VR Platform Data Collection: This section is dedicated to data collection from various mainstream VR platforms such as Microsoft, Oculus, Pico, PlayStation, Steam, and Viveport. The data collection is primarily conducted using Selenium, enabling efficient and parallel website visits. To ensure the most comprehensive page data is captured, the project conducts multiple visits to each site, selecting the longest page_source as the final material for analysis. 

PART2.
Experimental Tools and Analysis: The exper directory encompasses a variety of experimental tools and analysis scripts. These include the analysis of AndroidManifest.xml files in Android applications, drawing VR box pictures, category classification, compliance and readability analysis, game name collection, checking the validityof privacy policy URLs, privacy policy language and age compliance analysis, and more. Additionally, it includes a special part extractor for analyzing features mentioned in previous papers.

PART3.
Reverse Engineering: The reverse engineering directory of the project focuses on the reverse engineering of Oculus and Pico VR headsets. For applications developed with Unity, in-depth reverse analysis is conducted using il2cppdumper combined with IDA Pro. For applications built with Unreal Engine, the analysis centers on the main.obb.png file. 

PART4.
Utility Tools and Processing: The utils directory contains various auxiliary scripts and tools, such as saving the page source for all visited URLs, extracting content from PDF files, file deduplication tools, processing privacy policy URLs, merging CSV files, saving PDFs for privacy policy URLs, and a privacy policy translation tool. 
