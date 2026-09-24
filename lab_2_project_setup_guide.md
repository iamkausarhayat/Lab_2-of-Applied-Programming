# Employee Database Management System - Lab 2

Welcome to the Employee Database Management project. This is a C# Windows Forms Desktop Application that connects to a local SQL Server database to fetch and display employee records.

Follow the step-by-step instructions below to download, set up, and run this project on your computer.

---

## Step 1: Download the Project from GitHub

You need to download the code to your local machine first.

1. Go to the main page of this repository on GitHub.
2. Click on the green **"<> Code"** button located near the top right of the file list.
3. Select **"Download ZIP"** from the dropdown menu.
4. Once downloaded, extract (unzip) the folder to any location on your computer (e.g., your Desktop or Documents folder).

---

## Step 2: Set Up the Database in SQL Server

Before running the application, you must create the database and the table that the C# application will connect to.

1. Open **SQL Server Management Studio (SSMS)**.
2. Connect to your local SQL Server instance (usually `(localdb)\MSSQLLocalDB` or your computer's server name).
3. Click on **"New Query"** at the top left.
4. Copy the exact SQL query written below and paste it into the query window:

```sql
CREATE DATABASE EmployeeDB;
GO

USE EmployeeDB;
GO

CREATE TABLE Employee (
    Id INT PRIMARY KEY,
    Name VARCHAR(100),
    Cell VARCHAR(50),
    Address VARCHAR(255)
);
GO

-- Inserting some dummy data for testing
INSERT INTO Employee (Id, Name, Cell, Address) 
VALUES 
(102, 'Raja', '03324919274', 'Rawalpindi'),
(11, 'Qasim', '0332', 'abc');
```

5. Click the **"Execute"** button (or press `F5`). It should say "Commands completed successfully." Your database is now ready.

---

## Step 3: Open and Run the Project

Now that the code is downloaded and the database is ready, you can run the application.

1. Go to the folder where you extracted the downloaded ZIP file.
2. Double-click the file named **`Lab_2.slnx`** (or `Lab_2.sln`). This will automatically open the project in **Visual Studio**.
3. *Optional Check:* In Visual Studio, go to the Solution Explorer on the right, open the `Lab_2` project folder, and double-click `EmployeeDBConn.cs`. Ensure the `connectionString` matches your SQL server name. (If you used standard localdb, no changes are needed).
4. Click the green **"Start"** button at the top of Visual Studio (or press `F5` on your keyboard) to run the application.
5. Once the application window opens, click the **"View"** button to load the data from your database into the screen.