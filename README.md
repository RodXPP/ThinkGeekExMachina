[![Many Languages](https://github.com/RodXPP/ThinkGeekExMachina/actions/workflows/workflow.yaml/badge.svg)](https://github.com/RodXPP/ThinkGeekExMachina/actions/workflows/workflow.yaml)
[![.NET Playground](https://github.com/RodXPP/ThinkGeekExMachina/actions/workflows/dotnet.yml/badge.svg)](https://github.com/RodXPP/ThinkGeekExMachina/actions/workflows/dotnet.yml)

# Multi-Language Project Repository

This is a repository for storing and building projects written in various languages. This repository is equipped with a continuous integration setup using GitHub Actions that compiles and builds projects in the following languages:

- C
- C++
- C#
- Python
- Go

## Structure

Each project should be located in a subdirectory of the appropriate language directory. For example, a C++ project created by `person1` would have its source files located in the `c++/person1/src/` directory.

The directory structure for each project should be as follows:

```
cpp/person/src/filename.cpp for C++
c/person/src/filename.c for C
c#/person/src/Program.cs for C#
python/person/src/main.py for Python
go/person/src/main.go for GO
```

Where `language` is the programming language, `person` is the name of the person who created the project, and `src/` contains the source files of the project.

## Building

When changes are pushed to this repository, a GitHub Actions workflow is triggered that attempts to build each project. The specific build command depends on the language of the project.

If a build fails, the workflow will be marked as failed. Check the "Actions" tab in GitHub for more details on any build failures.

## Contributing

To contribute a project:

1. Fork this repository.
2. Add your project to the appropriate directory based on the language of your project.
3. Push your changes to your fork.
4. Open a pull request.

We hope that your projects will pass on the first try :)

