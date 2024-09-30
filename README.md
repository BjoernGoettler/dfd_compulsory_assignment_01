# Databases for Developers - Compulsory Assignment 01


## Requirements
At the time of writing, SQL Server in docker compose is broken. Our good old trusty CLI works, so it's a bit of typing (or copy/paste if you fancy)

```bash
docker pull mcr.microsoft.com/mssql/server:2022-latest
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Henning@Pressening" -p 1433:1433 --name sql2022 --hostname sql2022 --platform linux/amd64 -d mcr.microsoft.com/mssql/server:2022-latest
```


## Part 1: Manual Database Migration
sqlcmd want's us to accept the EULA, and we've got no problem with that. Let's export it, so we accept it for the entire session
```bash
export SQLCMD_ACCEPT_EULA=YES
```
The sqlcmd syntax is horrible, let's set an alias that shortcuts to sqldo, and just takes a *.sql file as paramter
```bash
alias sqldo="sqlcmd -S 127.0.0.1 -U sa -P Henning@Pressening -i "
```

Every migration is a script that is named by it's order in 4 digits, it's name, and filetype .sql
0000_initial_schema.sql is the first migration. The second is 0001_something.sql and so on.

For each migration there is a corresponding mygration with "_rollback" appended to it's name. It reverses it's corresponding migration.
0000_initial_schema_rollback.sql reverses 0000_initial_schema.sql




## Part 2: Part 2: Entity Framework Core Migrations