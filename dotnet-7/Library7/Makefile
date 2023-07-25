.DEFAULT_GOAL := build

.PHONY: build
build:
	dotnet build

.PHONY: clean
clean:
	dotnet clean

.PHONY: publish
publish:
	dotnet publish

.PHONY: run
run:
	dotnet run --project App

.PHONY: test
test:
	dotnet test

.PHONY: watch
watch:
	dotnet watch test --project Util.Tests
