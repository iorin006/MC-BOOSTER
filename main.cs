using System;
using System.Diagnostics;
using System.Threading;

namespace AutoRestartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MC BOOSTER v1.18.12";
            string appPath = @"C:\Program Files\WindowsApps\Microsoft.MinecraftUWP_1.18.1201.0_x64__8wekyb3d8bbwe\Minecraft.Windows.exe";
            Console.WriteLine("Ctrl + C で終了できます");

            while (true)
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = appPath;

                    // アプリケーションを開始
                    process.Start();

                    // アプリケーションの終了を待機
                    process.WaitForExit();
                }
                catch (Exception e)
                {
                    Console.WriteLine("エラーが発生しました: " + e.Message);
                    break;
                }
            }
        }
    }
}

