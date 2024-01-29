from androguard.core.bytecodes.dvm import DalvikVMFormat
from androguard.core.bytecodes.apk import APK
from androguard.core.analysis.analysis import Analysis
def analyze_apk(apk_path):
    a = APK(apk_path)
    
    # 获取APK的包名
    package_name = a.get_package()
    print(f"Package Name: {package_name}")

    # 获取APK的主活动
    main_activity = a.get_main_activity()
    print(f"Main Activity: {main_activity}")

    # 获取APK的权限
    permissions = a.get_permissions()
    print("\nPermissions:")
    for permission in permissions:
        print(permission)

def analyze_apk_for_sdk_methods(apk_path, sdk_keyword):
    a = APK(apk_path)
    d = DalvikVMFormat(a.get_dex())
    dx = Analysis(d)

    # 获取所有的方法
    methods = d.get_methods()
    
    for method in methods:
        # 检查方法是否包含SDK关键字
        if sdk_keyword in method.get_class_name():
            print(f"Found SDK method: {method.get_class_name()}->{method.get_name()}")

if __name__ == "__main__":
    apk_path = "E:\local1\《末世曙光》《行尸走肉：圣徒与罪人 – 第1章》（有com文件夹）\TWD_SS_CH1.apk" 
    apk_path = "E:\local1\疯狂过山车（有com文件夹）\Epic_Rollercoasters_8.5.2_FNAL.apk"
    analyze_apk(apk_path)
    analyze_apk_for_sdk_methods(apk_path, "Get")