using System;
using System.Diagnostics;
using System.Linq;

namespace PingAlive
{
    internal class Program
    {
        private const string ReleaseDate = "08/2023";

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine($"{Helper.GetAppName()}.exe {Helper.GetAppVersion()} (by MBODM {ReleaseDate})");
            Console.WriteLine();
            Console.WriteLine("A tiny Windows command-line tool to continuously ping Telekom´s primary DNS server");
            Console.WriteLine();
            Console.WriteLine("For more information just take a look at https://github.com/mbodm/pingalive-dotnet");
            Console.WriteLine();

            if (args.Any())
            {
                Helper.ShowError("Arguments are not supported", "Please restart executable without any command-line arguments");
                Environment.Exit(1);
            }

            try
            {
                // No validation here if cmd, start and ping really exist.
                // If not, you have a more serious problem than this, imo.
                // But i tested those scenarios and error-behavior was ok.

                var process = Process.Start("ping", "-t 194.25.2.129");
            }
            catch (Exception e)
            {
                Helper.ShowError("Starting ping command failed", $"Exception-Message was \"{e.Message}\"");
                Environment.Exit(2);
            }

            Helper.ShowSuccess();
            Environment.Exit(0);
        }
    }
}
