import PyPDF2

def extract_pdf_content(pdf_path):
    content = ""
    with open(pdf_path, 'rb') as file:
        reader = PyPDF2.PdfReader(file)
        for page_num in range(len(reader.pages)):
            page = reader.pages[page_num]
            content += page.extract_text()
    return content

pdf_path = "d:/pro/py/pycpro1/exper/name_age/pdfs/0ea046469905e22f72b83549a30569ac.txt.pdf"
print(extract_pdf_content(pdf_path).replace('\n', ''))
