# Medical-Image-Predictor
To create a database for the Medical Image Predictor project using .NET Core, we will follow these steps:

Create Database Tables: Define the MedicalImage and Prediction tables.

Set Up .NET Core Project: Create a .NET Core application and configure Entity Framework Core (EF Core) for database operations.

Reverse Engineering: Use EF Core commands to scaffold models and database context from the existing database.

Below is a detailed step-by-step guide:

# Step 1: Create Database Tables

We will create two tables: MedicalImage and Prediction in database.

# Step 2: Set Up .NET Core Project

2.1 Create a New .NET Core Project

Change name "MedicalImagePredictor" according to your project

    dotnet new console -o MedicalImagePredictor
    cd MedicalImagePredictor

# Install Entity Framework Core

    dotnet add package Microsoft.EntityFrameworkCore.Sqlite
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer  # For SQL Server

# Scaffolding (Reverse Engineering)  

Change Server and Database according to your server name and database 

    dotnet ef dbcontext scaffold "Server=ADIL-PC\\SQLEXPRESS;Database=MIP;Integrated Security=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer

"In Program.cs class write my code and chage it according to your project" 

"In the project directory, create Model.cs insert my code and change it according to your project"
