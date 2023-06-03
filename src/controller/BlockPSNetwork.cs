using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.IO;
using System.Reflection;

namespace ReFreeAdobe.src
{
    internal class BlockPSNetwork
    {
        public static string BlockPsNetwork(string version , string BinPath)
        {
            string back;
            string resourceName = "ReFreeAdobe.resources.BlockPS23.ps1";
            string scriptPath = Path.GetTempFileName() + ".ps1";

            // 从嵌入资源中获取.ps1文件内容
            using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(resourceStream))
                {
                    // 将.ps1文件内容写入临时文件
                    File.WriteAllText(scriptPath, reader.ReadToEnd());
                }
            }

            // 创建一个新的PowerShell进程
            Process process = new Process();

            // 设置进程启动信息
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = $"-ExecutionPolicy Bypass -File \"{scriptPath}\"";
            process.StartInfo.Verb = "runas"; // 以管理员身份运行
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            // 启动进程
            process.Start();

            // 等待进程完成
            process.WaitForExit();

            // 读取输出信息
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            // 输出结果
            back = "Output:\n";
            back = back + output;
            back = back + "\n\n\nError:\n";
            back = back + error;
            // 删除临时文件
            File.Delete(scriptPath);

            return back;
        }
    }
}
