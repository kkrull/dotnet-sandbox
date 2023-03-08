# Multi-project solution in .NET 7

## Create it

- Create solution: `dotnet new sln`
- Create library within that solution: `dotnet new classlib -o Util`
- Add the project to the solution: `dotnet sln add Util`

## Test it

- Add test project with xUnit: `dotnet new xunit -o Util.Tests`
- Add it to the solution: `dotnet sln add Util.Tests`
- Add reference to the project being tested: `dotnet add Util.Tests reference Util`
- Test it: `dotnet test`
