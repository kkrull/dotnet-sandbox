# .NET 8 test in VS Code

A base project for doing C# in .NET 8 in VS Code.

## Setup

- Install `dotnet` with homebrew: `brew install dotnet-sdk`.
- Create a .NET project in VS Code, using the extension: `ms-dotnettools.csdevkit`.
  - VS Code initially gave an error about a byte stream terminating before it could read the output.
  - Using the CLI, I found that the .NET solution didn't have the project added yet (`dotnet sln
    list`).  Adding the project (`dotnet sln add <csproj file>`) and re-starting VSCode did the
    trick.
- VS Code can now do .NET commands like clean and build.  It can also run the debugger.
- Add a test project by creating a new sub-directory for the project and then `dotnet new xunit`
  followed by `dotnet sln add <new CS project file>`.

## Tasks

### `dotnet build`

Builds the code in `bin/`/

### `dotnet format`

Formats source code according to `.editorconfig`.

### `dotnet run <CS Project>`

```shell
dotnet run --project ConsoleApp1/ConsoleApp1.csproj
```

### `dotnet test`

Run tests with xUnit.
