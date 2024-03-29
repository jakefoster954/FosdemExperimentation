# FosdemExperimentation
A chance to test out some tools presented at FOSDEM 2024

## Act
Act can be used to test GitHub Actions locally, removing the need to commit and push code every time you want to
test the CI pipeline.

### Installation

` brew install act`

### Issues
This doesn't currently work. Receives the following error:

`❗  ::error::Error: Unable to locate executable file: gem. Please verify either the file path exists or the file can be found within a directory specified by the PATH environment variable. Also check the file mode to verify the file is executable.`

This doesn't happen in GitHub.

## Vale
Vale is an open source, command line tool that helps you get real time feedback on your writing style as you write.

You can configure Vale with a base styling guide: Microsoft has been used in the following repository. You can also add
custom rules to tailor the tool to the needs of the project.

Vale can be used to validate Markdown, HTML, line comments, block comments and much more.

***NB: Vale runs entirely offline ensuring that your content is never sent to a remote server for processing.***


### Getting Started
Vale has comprehensive documentation which can be found [here](https://vale.sh/docs/vale-cli/overview/).

#### Installation
To install Vale, run the following command:

`brew install vale`

#### Configuration

##### .vale.ini
Defines what files to lint and how to lint them

##### /styles/config/vocabularies
Create a project specific terminology list. This is case aware by default.

##### /styles/config/dictionaries
Create dictionaries to define custom dictionaries

##### /styles/config/ignore
Ignores words during spellcheck

##### /styles/config/output
Define Vale report output format


#### Useful commands
 - `vale sync`
   - Load the .vale.ini file
 - `vale {{ FILENAME }}`
   - Run a vale scan on {{ FILENAME }}

## Markup Lint Checker
 Markup link checker (MLC) validates links in Markdown and HTML files in your solution.

Documentation on MLC can be found [here](https://github.com/becheran/mlc?tab=readme-ov-file)

### Installation
MLC can be installed via cargo - rust's package manager

#### Install Cargo
` brew install cargo`

Add cargo to PATH. You can do this by adding the following to your .zshrc:
`export PATH=$PATH:~/.cargo/bin/`

#### Install Markup Lint Checker
`cargo install mlc`

### Useful commands
 - `mlc`
   - Run MLC
 - `mlc {{ PATH }}`
   - Run MLC on a certain directory or path

## Stryker
Stryker is a testing tool to test the efficiency of your tests.

The documentation can be found [here](https://stryker-mutator.io/)

### Installation
Stryker can be installed globally:

`dotnet tool install -g dotnet-stryker`

or on a project level:

```
dotnet new tool-manifest
dotnet tool install dotnet-stryker
```
This creates a *.config/dotnet-tools.json* which can be committed to git then installed
by the rest of your team by executing the following command:

`dotnet tool restore`

### Useful commands
To run Stryker, navigate to the solution folder and run

`dotnet stryker`

This will generate a HTML report in *StrykerOutput*

### Issues

When installing, you can use `--ignore-failed-sources` if you can't restore any package sources
to treat package source failures as warning. Documentation can be found
[here](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-install)

## Postgres
Analysis of Postgres cost and performance depending on structure of
database.

### Installation
Ensure you have **Docker Desktop** installed and running.

#### Build the demo Postgres image
From project root, build the docker image. This is a Postgres container
that executes all \*.sql files located in the project root.

`docker build -t custom-postgres .`

You can view the newly created image by running `docker images`.

Next create a container from the newly created image.

`docker run -d --name my-postgres-container -e POSTGRES_PASSWORD=password custom-postgres:latest`

- "-d" flag specifies that the container should execute in the background
- "--name" option assigns the container’s name. For example, "basic-postgres"
- "-p" assigns the port for the container. For example, "5432:5432"
- "-e POSTGRES\_PASSWORD" configures the password to be "password"
- "postgres" is the official Docker image

You must provide the environment variable *POSTGRES_PASSWORD*.

You can verify the container is running via `docker ps`.

#### Interact with container

`docker exec -it my-postgres-container bash`

Connect to the Postgres database

`psql -h localhost -U postgres`

- "-h" flag is the hostname
- "-U" is the user. "postgres" is default admin

### Useful commands

#### Show databases

`\l;`

#### Connect to database

`\c my_first_database;`

#### Show tables
Basic view:

`\dt;`

Show tables including size and description:

`\dt+;`

#### Evaluate performance

Show the query plan for a query:

`EXPLAIN query;`

Show and execute the query plan for a query

`EXPLAIN ANALYZE query;`

Collect statistics:

`ANALYZE table_name;`
