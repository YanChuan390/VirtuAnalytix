using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

class Il2CppAnalysis
{
    static void Main(string[] args)
    {
        string libIl2CppPath = "libil2cpp.so";
        string csFilesDirectory = "D:/pro/py/pycpro1/reverse engineering/Pico Reverse Engineering/for_pico_apks_unity/inv_folder_0/000_1976决胜空战 1976_Back_to_Midway_2.81_FNAL/Assembly-CSharp/Assembly-CSharp.decompiled.cs";
        string idaExecutablePath = "E:/idapro/ida64.exe";
        string decompiledOutputPath = "temp_folder";

        FieldOffsetSearch(libIl2CppPath, csFilesDirectory, idaExecutablePath, decompiledOutputPath);
    }

    static void FieldOffsetSearch(string libIl2CppPath, string csFilesDirectory, string idaExecutablePath, string decompiledOutputPath)
    {
        using (StreamWriter sw = new StreamWriter("result.txt"))
        {
            foreach (string file in Directory.EnumerateFiles(csFilesDirectory, "*.cs"))
            {
                string content = File.ReadAllText(file);
                foreach (Match match in Regex.Matches(content, @"FieldOffset\(Offset = ""(0x[0-9A-Fa-f]+)""\)"))
                {
                    string fieldOffset = match.Groups[1].Value;
                    Console.WriteLine($"Found FieldOffset: {fieldOffset} in file: {file}");

                    // 执行IDA命令
                    Process idaProcess = new Process();
                    idaProcess.StartInfo.FileName = idaExecutablePath;
                    idaProcess.StartInfo.Arguments = $"-B -o{decompiledOutputPath} {libIl2CppPath}";
                    idaProcess.StartInfo.UseShellExecute = false;
                    idaProcess.Start();
                    idaProcess.WaitForExit();

                    // 分析IDA生成的反编译文件
                    string decompiledContent = File.ReadAllText(decompiledOutputPath);
                    int offsetIndex = decompiledContent.IndexOf(fieldOffset);
                    if (offsetIndex != -1)
                    {
                        int contextStart = Math.Max(0, offsetIndex - 100);
                        int contextEnd = Math.Min(decompiledContent.Length, offsetIndex + 100);
                        string context = decompiledContent.Substring(contextStart, contextEnd - contextStart);

                        Console.WriteLine($"Offset {fieldOffset} found in decompiled file.");
                        sw.WriteLine($"libIl2CppPath: {libIl2CppPath}, csFilesDirectory: {csFilesDirectory}, FieldOffset: {fieldOffset}, Context: {context}");
                    }
                }
            }
        }
    }
}
