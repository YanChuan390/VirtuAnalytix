# import sys
# from androguard.core.bytecodes.apk import APK
# from androguard.core.analysis.analysis import Analysis
# from androguard.core.bytecodes.dvm import DalvikVMFormat

# sys.stdout = open("result.txt", "w")

# def generate_class_diagram(apk_path):
#     # Load APK and related DEX
#     a = APK(apk_path)
#     d = DalvikVMFormat(a.get_dex())
#     dx = Analysis(d)

#     # Create the analysis of the APK
#     dx.create_xref()

#     # Iterate over classes and methods and print them
#     for clazz in d.get_classes():
#         print(f"Class: {clazz.get_name()}")
#         for method in clazz.get_methods():
#             print(f"    Method: {method.get_name()}")

# if __name__ == '__main__':
#     apk_path = "E:\local1\巴黎圣母院（有com文件夹）\Eternal_Notre-Dame_1.6.2_FNAL.apk"
#     generate_class_diagram(apk_path)

import sys
from androguard.core.bytecodes.apk import APK
from androguard.core.analysis.analysis import Analysis
from androguard.core.bytecodes.dvm import DalvikVMFormat
def generate_class_diagram(apk_path):
    # Load APK and related DEX
    a = APK(apk_path)
    d = DalvikVMFormat(a.get_dex())
    dx = Analysis(d)
    d.set_decompiler(DecompilerDAD(d, dx))  # Add this line

    # Create the analysis of the APK
    dx.create_xref()

    # Iterate over classes
    for clazz in d.get_classes():
        if "VRTrackingMode" in clazz.get_name():
            # Print class name
            print(f"Class: {clazz.get_name()}")
            
            # Print the class code
            print(clazz.get_source())
            print("--------------------------------------------------")

if __name__ == '__main__':
    from androguard.decompiler.decompiler import DecompilerDAD  # Import this at the top
    apk_path = "E:\local1\巴黎圣母院（有com文件夹）\Eternal_Notre-Dame_1.6.2_FNAL.apk"
    generate_class_diagram(apk_path)