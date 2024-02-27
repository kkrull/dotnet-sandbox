# .NET 8 test in VS Code

A base project for doing C# in .NET 8 in VS Code.

## Creating a sub-project

Install the tools listed in [Tools](#tools), then create a C# console app.

I used the C# Dev Kit extension to create a console app.  It created a project and a solution, but
it did not add the project to the solution.  VS Code gave errors at that point, that were addressed
by me using `dotnet sln` to add the project to the solution.

## Tasks

### `dotnet build`

Build the code in each project and output assemblies to their respective `bin/` folders.

### `dotnet clean`

Remove previously-built assemblies from `bin/`.

### `dotnet format`

Format source code according to the rules in `.editorconfig`.

`dotnet format --whitespace` runs significantly faster, for simple formatting.

### `dotnet run <.csproj>`

```shell
dotnet run --project ConsoleApp1/ConsoleApp1.csproj
```

### `dotnet test`

Run tests with xUnit.

## Tools

### .NET SDK

- Install `dotnet` with homebrew: `brew install dotnet-sdk`.
- List installed SDK versions: `dotnet --list-sdks`.

### VS Code

Install these extensions:

- C#: `ms-dotnettools.csharp`
- .NET Core Test Explorer: `formulahendry.dotnet-test-explorer`
- .NET Install Tool: `ms-dotnettools.vscode-dotnet-runtime`

C# Dev Kit (`ms-dotnettools.csdevkit`) is not recommended, because it requires some [additional
licensing](https://code.visualstudio.com/docs/csharp/cs-dev-kit-faq#_who-can-use-c-dev-kit).

### xUnit

Make a new directory for another project's tests (e.g. `Library.Tests/` for `Library/`).  Then
initialize a test project with a template for xUnit:

```sh
cd <test project directory> #to the blank directory just created
dotnet new xunit
```

Then add the test project to the solution and a project reference so the test project can load the
production code it is testing.

```sh
cd .. #Back to the directory with the .sln file
dotnet sln add <test .csproj>
dotnet add <test .csproj> reference <production .csproj>
```
