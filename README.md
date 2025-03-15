# 📚 Library Management System - Setup Instructions

## 🔹 1. Prerequisites
Before setting up the project, ensure you have the following installed:
- ✅ **.NET SDK** (Latest Version)
- ✅ **SQL Server** & **SQL Server Management Studio (SSMS)**
- ✅ **Visual Studio 2022+** (with .NET desktop development)
- ✅ **Git** *(optional, for version control)*

---

## 🔹 2. Configure the Database Connection
1. Open the project in **Visual Studio**.
2. Navigate to **`App.config`** *(in `Library.Presentation` project).*
3. Locate the `<connectionStrings>` section:
   ```xml
   <connectionStrings>
       <add name="ConnectionString"
           connectionString="Server=YOUR_SERVER_NAME;Database=LibraryDB;Trusted_Connection=True; TrustServerCertificate=True;"
           providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
4. Replace `YOUR_SERVER_NAME` with your **SQL Server instance name** and save the file.

---

## 🔹 3. Configure Email Credentials
The system sends email notifications for due date reminders. Update your email credentials:
1. Open **`App.config`**.
2. Find the email settings section and modify these values:
   ```xml
   <appSettings>
       <add key="EmailAddress" value="YOUR_EMAIL@gmail.com" />
       <add key="EmailPassword" value="YOUR_PASSWORD" />
   </appSettings>
   ```
3. **Important:** using **Gmail**, enable **Less Secure Apps** or create an **App Password**.

---

## 🔹 4. Run Database Migrations
- Ensure that **SQL Server is running** in the Services.
- Open **Package Manager Console** in Visual Studio:
  - Navigate to **Tools > NuGet Package Manager > Package Manager Console**.
- Run the following command to apply database migrations:
   ```powershell
   Update-Database
   ```
- **If the command does not work:**
  - Remove the migration files from the `Models` folder.
  - Create a new migration:
   ```powershell
   Add-Migration MigrationName
   ```
- Ensure that `LibraryDB` is created in **SQL Server**.

---

## 🔹 5. Running the Application
### ▶️ **To run the desktop application:**
- In **Visual Studio**, set `Library.Presentation` as the **Startup Project**.
- Press `F5` or click **Start** to launch the application.

### ▶️ **To run the automated email reminder service:**
- Navigate to the **Console App** folder in `cmd` or **PowerShell**.
- Run the following command:
   ```sh
   dotnet run
   ```
- The service will schedule reminders **daily at 9 AM**.

---

## 🔹 6. Default Login Credentials
| Role      | Username        | Password  |
|-----------|---------------|-----------|
| **Admin** | `salemgamall`  | `admin`   |
| **Member**| `ahmedMohamed` | `member`  |
| **Librarian** | `malak` | `librarian`  |

---

## 🔹 7. Troubleshooting
- ❗ **If emails are not sent:** Check **SMTP settings** and ensure your email provider allows outgoing emails.
- ❗ **If the database does not connect:** Verify the **SQL Server instance** and credentials.
- ❗ **If the console app does not run automatically:** Consider using **Windows Task Scheduler**.

---
### 🚀 Enjoy using the Library Management System! 🎉

