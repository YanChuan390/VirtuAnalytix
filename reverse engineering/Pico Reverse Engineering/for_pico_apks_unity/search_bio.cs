#r "nuget: Microsoft.CodeAnalysis.CSharp, 3.8.0"

using System;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

Console.WriteLine("Hello, world!");

public class SubstringChecker {
    public static bool ContainsSubstringWithUpperCaseFollowing(string s, string x) {
        // 检查s是否包含子串x
        if (s.Contains(x)) {
            int position = s.IndexOf(x);

            if (position + x.Length >= s.Length) { // 如果x是s的末尾部分，返回true
                return true;
            }

            char nextChar = s[position + x.Length]; // 获取x后面的第一个字符

            return char.IsUpper(nextChar); // 检查该字符是否为大写字母
        }

        // 如果s不包含x，返回false
        return false;
    }
}

class jojo {
    public static string Main(string path) {
        string code = File.ReadAllText(path);
        string result = AnalyzeCode(code);
        return result;
    }

    static string AnalyzeCode(string code) {
        SyntaxTree tree = CSharpSyntaxTree.ParseText(code);
        var root = tree.GetRoot();
        StringBuilder resultBuilder = new StringBuilder();

        foreach (var node in root.DescendantNodes()) {
            if (node is VariableDeclarationSyntax variableDeclaration) {
                foreach (var variable in variableDeclaration.Variables) {
                    string variableName = variable.Identifier.Text;
                    AppendResultIfRelated("[variableName] ", variableName, resultBuilder);
                }
            } else if (node is MethodDeclarationSyntax methodDeclaration) {
                string methodName = methodDeclaration.Identifier.Text;
                AppendResultIfRelated("[methodName] ", methodName, resultBuilder);
            }
        }

        return resultBuilder.ToString();
    }

    static void AppendResultIfRelated(string var_or_method, string name, StringBuilder resultBuilder) {
        if (IsEyeRelated(name)) {
            resultBuilder.AppendLine(var_or_method + "Eye: " + name);
        } else if (IsHeadRelated(name)) {
            resultBuilder.AppendLine(var_or_method + "Head: " + name);
        } else if (IsEnvRelated(name)) {
            resultBuilder.AppendLine(var_or_method + "Environment: " + name);
        } else if (IsHandRelated(name)) {
            resultBuilder.AppendLine(var_or_method + "Hand: " + name);
        } else if (IsBodyRelated(name)) {
            resultBuilder.AppendLine(var_or_method + "Body: " + name);
        } else if (IsFaceRelated(name)) {
            resultBuilder.AppendLine(var_or_method + "Face: " + name);
        }
    }

    static bool IsEyeRelated(string name) {
        return SubstringChecker.ContainsSubstringWithUpperCaseFollowing(name, "Eye");
    }

    static bool IsHeadRelated(string name) {
        return SubstringChecker.ContainsSubstringWithUpperCaseFollowing(name, "Head");
    }    

    static bool IsEnvRelated(string name) {
        return SubstringChecker.ContainsSubstringWithUpperCaseFollowing(name, "boundary")
        || SubstringChecker.ContainsSubstringWithUpperCaseFollowing(name, "room")
        || SubstringChecker.ContainsSubstringWithUpperCaseFollowing(name, "locate");
    } 

    static bool IsHandRelated(string name) {
        return SubstringChecker.ContainsSubstringWithUpperCaseFollowing(name, "Hand");
    } 

    static bool IsBodyRelated(string name) {
        return SubstringChecker.ContainsSubstringWithUpperCaseFollowing(name, "Body")
        || SubstringChecker.ContainsSubstringWithUpperCaseFollowing(name, "Bone")
        || SubstringChecker.ContainsSubstringWithUpperCaseFollowing(name, "Skeleton");
    } 

    static bool IsFaceRelated(string name) {
        return SubstringChecker.ContainsSubstringWithUpperCaseFollowing(name, "Face");
    } 
}


class Program2 {
    public static void Main() {
        // string folderPath = "C:\\Users\\Administrator\\Desktop\\jijiji";
        string folderPath = "F:\\for_pico_apks";
        SearchCsFiles(folderPath);
    }

    static void SearchCsFiles(string folderPath) {
        try {
            foreach (string file in Directory.GetFiles(folderPath, "*.cs")) {
                string filePath = Path.GetFullPath(file);
                if (false || (filePath.Contains("Assembly-CSharp") && !filePath.Contains("Assembly-CSharp-firstpass"))) {

                    Console.WriteLine("cur: " + filePath);

                    string directoryPath = Path.GetDirectoryName(filePath);
                    string tempFilePath = Path.Combine(directoryPath, "temp12312.txt");

                    if (File.Exists(tempFilePath)) {// 如果文件存在，删除它
                        File.Delete(tempFilePath);
                    }

                    // 要写入文件的内容
                    string contentToWrite = jojo.Main(filePath);

                    // 写入内容到 temp.txt 文件中
                    File.WriteAllText(tempFilePath, contentToWrite);
                }
            }

            foreach (string subDir in Directory.GetDirectories(folderPath)) {
                SearchCsFiles(subDir); // 递归调用以遍历子文件夹
            }
        } catch (System.Exception e) {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
// Program p = new Program();
// Console.WriteLine(Program.test());
Program2.Main()