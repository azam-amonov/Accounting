## Accounting Project

This project allows you to easily track your income and expenses.

**Features:**

* Record income and expenses
* View your financial data

---

### **Getting Started**

####  **Clone the project:**

   ```bash
   git clone git@github.com:azam-amonov/AccountingTable.Web.git
```

### Set up database:
1. **Install the .NET CLI (if not already installed):**
    > Follow the instructions on the official Microsoft documentation: https://learn.microsoft.com/en-us/dotnet/core/install/windows

2. **Update database connection string (appsettings.json):**
    > Open appsettings.json and replace the placeholder values in the DefaultConnection property with your actual 
     database configuration:
      >``` json
      > "ConnectionStrings" : {
      >     "DefaultConnection": "Host=localhost; Port=5432; Database=PersonalAccounting; Username=postgres; Password=your_password" }
    
   - Replace localhost with your database server address if it's different.
   - Replace 5432 with your database port (default for PostgreSQL is 5432).
   - Replace PersonalAccounting with your desired database name.
   - Replace postgres with your database username.
   - Replace your_password with your actual database password.
3. **Run database migrations:**
   > Navigate to the project directory and execute these commands:
    > ``` bash
    > cd Accounting/MicrosAccount.Api
    > dotnet ef migrations add InitialMigrations
    > dotnet ef database update


---

### Frontend Installation
#### If you want to use a web-based interface for managing your finances, you can install the AccountingTable.Web project from GitHub:
1. Install the frontend from this [repository].
    ``` bash
    git clone git@github.com:azam-amonov/AccountingTable.Web.git
   
2. Inside the `src/api` directory, locate the `apiConfig.js file.
    ``` text
    ├── src
    │   ├── api
    │   │   └── apiConfig.js

3. Replace the host in the `apiConfig.js` file with your own configuration.
    ``` react
    const BASE_URL = 'https://localhost:5177/api'
    export default BASE_URL;
    ```

[repository]: https://github.com/azam-amonov/AccountingTable.Web