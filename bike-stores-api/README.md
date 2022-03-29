# Bike Stores API

First run `dotnet ef database update 20220319003006_InitialMigration` to scaffold db and table.

Then run `./MSSQL-Sample-Db/BikeStores Sample Database - load data.sql` to load sample data

Snippet to generate controllers with the `dotnet` cli.

```bash
dotnet aspnet-codegenerator controller -name YourController -async -api -m Store -dc BikeStoresContext -outDir Controllers
```