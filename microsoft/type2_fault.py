import os

def line_process(file_path): # 删掉一些行

    bad = ['Demo movie for immersive headsets', 'Demo movie for HoloLens', 
    'Technical Preview Features', 'Known issues', 'More things to try', 
    'Manipulate your assets', 'CONTROLS', 'Supported image file format', 'Note', 
    'No Limits', 'Get in touch', 'In-app_purchases', 'Visit our website http', 'We all know the situation', 
    'Microsoft Mixed Reality', 'Show the World', 'This_app_can', "In-app_purchases"]

    with open(file_path, "r", encoding="utf-8") as f:
        lines = []
        for i in f.readlines():
            i = i.strip()
            j = i.split(':', 1)
            if len(j) <= 1 or len(j[0]) > len("Report_this_productApproximate_size") or (not j[0][0].isalpha()) or j[0] in bad:
                lines[-1] = lines[-1] + i
            else:
                lines.append(i)
                
    with open(file_path, "w", encoding="utf-8") as f:        
        for i in lines:
            if "503" not in i:
                f.write(i + "\n")

def folder_file_line_process(folder_path): # 对文件夹中的每个文件执行line_process
    for root, dirs, files in os.walk(folder_path):
        for file in files:
            file_path = os.path.join(root, file)
            line_process(file_path)

if __name__ == "__main__":
    folder_file_line_process("type2_result")