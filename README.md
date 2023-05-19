# Hair Salon

#### An application allowing the hair salon owner to add and keep track of their stylist and their respective clients.

#### By Kyle Crawford

## Technologies Used

* C#
* .NET
* SQL
* MySQL
* MySQL Workbench
* Entity Framework Core

## Description

This application gives the user the ability to keep track of all of their salon stylist by letting them add individual clients unique to each stylist.

## How To Run This Project

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

### Set up the Databases

Follow the instructions in the LearnHowToProgram.com lesson ["Creating a Test Database: Exporting and Importing Databases with MySQL Workbench"](https://www.learnhowtoprogram.com/lessons/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench) to use the `kyle_crawford.sql` file located at the top level of this repo to create a new database in MySQL Workbench with the name `kyle_crawford`.

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "HairSalon".
3. Within the production directory "HairSalon", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=kyle_crawford;uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
  }
}
```

5. Within the production directory "Template", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

* _Any known issues_
None

## License
[MIT](https://opensource.org/license/mit)

Copyright (c) 2023 Kyle Crawford