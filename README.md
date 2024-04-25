# Accounting

----
Project to save Income and Expenses.
To run project on your machine clone it and on MicrosAccount.Api file add 
migrations with code 

`dotnet ef migrations add InitialMigartions`

`dotnet ef database update`

before update database change ConnectionString on appsettings.json 
to your configuration

````
  "ConnectionStrings" : {
    "DefaultConnection": "Host = localhost, Port = 5234; Database = PersonalAccounting; Username = postgres; Password = qwerty"
  }
````

To use Front side of project install
https://github.com/azam-amonov/AccountingTable.Web.git

enter your configuration in apiConfig
````

├── src
│   ├── api
│   │   └── apiConfig.js

````

replace teh host with your!

