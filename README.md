# AIUB Canteen Management System

A Windows Forms desktop application for managing canteen sales, product inventory, invoices, and user roles. The system was built with C#, .NET Framework, ADO.NET, and Microsoft SQL Server.

## Repository Description

Windows Forms desktop application for canteen sales and inventory management built with C#, .NET Framework, ADO.NET, and SQL Server.

**AIUB Canteen Management System | C# Windows Forms Application**  
Built a desktop-based canteen management system using C#, Windows Forms, ADO.NET, and SQL Server. Implemented role-based login for Admin and Salesman users, product inventory management, cart-based sales processing, invoice generation, and sales history tracking.

## Demo Video

Watch the project demo here:
[Project Demo Video](https://drive.google.com/file/d/1MbIDuezIoKybSILPrJLOgnt9wQyQGp-y/view?usp=drive_link)


## Authors
1. Pulock Kumar Kundu,
2. Rezwan Ahmed Prottoy,
3. Mohammad Ahnaf Ibtahaz

## Supervisor
Md. Hasibul Hasan,
 Assistant Professor, Department of Computer Science, AIUB


## Features

- Secure login for Admin and Salesman users
- Role-based access control
- Admin dashboard for managing users, products, and sales records
- Salesman dashboard for processing sales and viewing personal sales history
- Product inventory management with add, update, search, and delete operations
- Cart-based sales system with automatic stock update
- Invoice generation after sale confirmation
- Sales history filters for last 7 days, last 30 days, and full records
- Profile update option for users

## Technologies Used

- C#
- .NET Framework 4.7.2
- Windows Forms
- ADO.NET
- Microsoft SQL Server
- SQL Server Management Studio

## Project Structure

```text
AIUB_Canteen_Management_System_GitHub_Ready/
├── README.md
├── .gitignore
├── PracticeGridview.sln
├── PracticeGridview/
│   ├── Forms, UserControls, DataAccess, Resources
│   └── App.config
└── database/
    └── CsharpProject.sql
```

## Database Setup

1. Open SQL Server Management Studio.
2. Create a database named `CsharpProject`.
3. Open the script from:

```text
database/CsharpProject.sql
```

4. Execute the SQL script.
5. Open `PracticeGridview/App.config` and update the connection string if needed.

Default connection string:

```xml
<add name="DefaultConnection"
     connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=CsharpProject;Integrated Security=True;"
     providerName="System.Data.SqlClient" />
```

If your SQL Server name is different, change `.\SQLEXPRESS` to your own server name.

## Demo Login Credentials

| Role | User ID | Password |
|---|---|---|
| Admin | u-001 | admin123 |
| Salesman | u-004 | sales123 |

## How to Run

1. Open `PracticeGridview.sln` in Visual Studio.
2. Restore/build the solution.
3. Make sure SQL Server is running.
4. Update the database connection string in `App.config`.
5. Run the project.


## Notes

This repository contains demo database records only. Build output folders such as `bin`, `obj`, and Visual Studio cache files are intentionally excluded.
