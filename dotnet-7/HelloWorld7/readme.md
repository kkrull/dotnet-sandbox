# Hello World in .NET 7

Hello World console application in .NET 7.

Source: https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0

## Install .NET SDK

1. Install a recent .NET SDK: `brew install dotnet-sdk`
1. Verify what got installed: `dotnet --info`

```shell
.NET SDK:
 Version:   7.0.201
 Commit:    68f2d7e7a3

...

.NET SDKs installed:
  3.1.412 [/usr/local/share/dotnet/sdk]
  7.0.201 [/usr/local/share/dotnet/sdk]

.NET runtimes installed:
  Microsoft.AspNetCore.App 3.1.18 [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 7.0.3 [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 3.1.18 [/usr/local/share/dotnet/shared/Microsoft.NETCore.App]
  Microsoft.NETCore.App 7.0.3 [/usr/local/share/dotnet/shared/Microsoft.NETCore.App]

Other architectures found:
  None

Environment variables:
  Not set

global.json file:
  Not found
```

## Create the application

```shell
mkdir HelloWorld7
cd HelloWorld7
dotnet new console --framework 7.0
```

This creates a standalone project, without a solution.

## Run the application

Run it in one command (Debug configuration):

```shell
dotnet run
```

Or do it in two:

```shell
dotnet build
dotnet bin/Debug/net7.0/HelloWorld7.dll
```

### Release Configuration

If you're feeling frisky, build it for Release:

```shell
dotnet run --configuration Release
```

## Publish the application

This makes an executable that can run on the target platform (e.g. an executable
file like `.exe` on Windows):

```shell
dotnet publish --configuration Release
```

Then it runs like so (macOS example):

```shell
./bin/Release/net7.0/publish/HelloWorld7
```

## VS Code Integration

VS Code has to be opened in this directory with just the one solution, not in
the parent (repository root).  Otherwise, it complains about not being able to
configure the .NET SDK.

Use Run -> Add Configuration to get VS Code to configure the .NET SDK for this
project.  This caused some useful-looking files to be created in `.vscode/`,
which I'm adding to source control.  Check your own editor's files in too, if
you want: the two can probably co-exist.

Source:
https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0#create-the-app
