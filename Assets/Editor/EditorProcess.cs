using System;
using System.Diagnostics;
using System.IO;
using UnityEditor;
using Debug = UnityEngine.Debug;

public class EditorProcess : Editor
{
    [MenuItem("Tools/Roslyn Analyzer", false, 1)]
    public static void CodeAnalyze()
    {
        Debug.Log("Call Analyzer");
        var processInfo = new ProcessStartInfo("cmd.exe", "dotnet build >> output.txt");
        processInfo.CreateNoWindow = false;
        processInfo.UseShellExecute = false;

        var process = Process.Start(processInfo);

        process.WaitForExit();
        //process.Close();
    }
}
