using System;
using System.Diagnostics;
using System.IO;

namespace transfer
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                throw new ArgumentException("A file was not specified.");
            }
            var startInfo = new ProcessStartInfo("curl.exe");
            startInfo.UseShellExecute = false;
            startInfo.Arguments = $"https://transfer.sh/{Path.GetFileName(args[0])} --upload-file {string.Join(' ', args)}";
            Process.Start(startInfo).WaitForExit();
        }
    }
}
