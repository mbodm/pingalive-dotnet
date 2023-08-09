using System;
using System.Linq;
using System.Reflection;

namespace PingAlive
{
    internal class Helper
    {
        public static string GetAppName()
        {
            return Assembly.GetExecutingAssembly().GetName().Name;
        }

        public static string GetAppVersion()
        {
            // This project is using the newer "SDK style project format", which became a default since .NET Core:
            // - Inside of .csproj file the <Version> tag is used for the so-called "Package Version", by default.
            // - In VS2022 see menu -> Project -> [PROJ-NAME] Properties -> Package -> General -> Package Version.
            // - The "AssemblyInformationalVersionAttribute" can be used to access that project-setting from code.

            // For more information please take a look at either the post of Edi Wang, or the post of Andrew Lock:
            // - https://edi.wang/post/2018/9/27/get-app-version-net-core
            // - https://andrewlock.net/version-vs-versionsuffix-vs-packageversion-what-do-they-all-mean/

            return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        }

        public static void ShowSuccess()
        {
            Console.WriteLine("Result:");
            Console.WriteLine("- Successfully started ping command (ping -t 194.25.2.129) in a separate window");
            Console.WriteLine("- The ping command is running until you press CTRL+C there or close that window");
            Console.WriteLine();
            Console.WriteLine("Have a nice day.");
        }

        public static void ShowError(params string[] errorMessages)
        {
            Console.WriteLine("Error:");
            errorMessages.ToList().ForEach(errorMessage => Console.WriteLine($" - {errorMessage}"));
            Console.WriteLine();
            Console.WriteLine("Please try again, or create a GitHub issue if you can´t solve the problem.");
        }
    }
}
