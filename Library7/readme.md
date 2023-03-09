# Multi-project solution in .NET 7

Trying out a .NET solution with multiple projects in it, so I can re-familiarize
myself with the build tools again.

## Initial Setup

- Create solution: `dotnet new sln`
- Create library within that solution: `dotnet new classlib -o Util`
- Add the project to the solution: `dotnet sln add Util`

## Development

TL;DR - Use the `Makefile`!

### Build it

```shell
dotnet build #-or-
make build
```

### Run it

- Add a console application project: `dotnet new console -o Greeter --use-program-main`
- Add it to the solution: `dotnet sln add Greeter`
- Add a reference to the Util project: `dotnet add Greeter reference Util`

```shell
dotnet run [-- project <project>] #-or-
make run
```

### Test it

- Add test project with xUnit: `dotnet new xunit -o Util.Tests`
- Add it to the solution: `dotnet sln add Util.Tests`
- Add reference to the project being tested: `dotnet add Util.Tests reference Util`
- Test it: `dotnet test`

```shell
dotnet test #-or-
make test
```

### Watch it

```shell
dotnet watch test --project Util.Tests #-or-
make watch
```
