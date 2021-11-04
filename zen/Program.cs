using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace zen
{
    class Program
    {
        private static string saveDir = @"C:\UserData\z004c1aw\OneDrive\Notizen\Zen";

        static void Main(string[] args)
        {
            Console.Title = "Zen";

            Console.Clear();

            if (!Environment.MachineName.EndsWith("RE1C"))
            {
                saveDir = saveDir.Replace("C:\\", "D:\\");
            }

            Directory.SetCurrentDirectory(saveDir);

            var filename = Guid.NewGuid() + ".txt";

            var fileInfo = new FileInfo(filename);

            File.WriteAllText(fileInfo.FullName, string.Empty, Encoding.UTF8);

            var sb = new StringBuilder();
            var line = Console.ReadLine();
            while (line.Trim() != "EOF")
            {
                sb.AppendLine(line);
                File.AppendAllText(filename, line + Environment.NewLine, Encoding.UTF8);
                line = Console.ReadLine();
            }

            Console.WriteLine($"[{fileInfo.Name}](vscode://file/{fileInfo.FullName})");

            Process.Start("explorer.exe", saveDir);
        }
    }
}
