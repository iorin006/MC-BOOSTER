using System;
using System.Diagnostics;
using System.IO;

namespace AutoRestartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MC BOOSTER master_ver";

            string log = "path.txt";
            string addpath;

            try
            {
                using (StreamReader reader = new StreamReader(log))
                {
                    addpath = reader.ReadLine();
                }

                string test = "MC BOOSTER\n";
                int width = Console.WindowWidth;
                int padding = (width - test.Length) / 2;
                string centeredText = new string(' ', padding) + test;
                Console.WriteLine(centeredText);
                Console.WriteLine("Path: " + addpath);
                Console.WriteLine("Ctrl + C で終了できます");

                while (true)
                {
                    try
                    {
                        Process process = new Process();
                        process.StartInfo.FileName = addpath;

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
            catch (FileNotFoundException)
            {
                Console.WriteLine("ファイルが見つかりません。");
            }
            catch (Exception e)
            {
                Console.WriteLine("エラーが発生しました: " + e.Message);
            }
        }
    }
}
