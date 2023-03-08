# Multi-project solution in .NET 7

## Create it

- Create solution: `dotnet new sln`
- Create library within that solution: `dotnet new classlib -o Greeter`
- Add the project to the solution: `dotnet sln add Greeter/Greeter.csproj`
