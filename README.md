# pingalive-dotnet
A tiny .NET Windows command-line tool to continuously ping Telekom´s primary DNS server

If you want to customize and build the application on your own, just follow these steps:
- Make sure Visual Studio 2022 (any edition) is installed with selected "_.NET desktop development_" workload
- Or make sure you have at least "_.NET Framework 4.8 SDK_" installed if you are not using Visual Studio
- Clone or download source code into some folder (in example `C:\Projects`)
- Open a Command Prompt or PowerShell window
- Navigate to folder where `PingAlive.csproj` file is located (in example `cd C:\Projects\pingalive-dotnet\src\PingAlive`)
- Run following command: `dotnet publish -c Release PingAlive.csproj`
- Now you can find the release binary in"_bin\Release\net48\publish_" folder
