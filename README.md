# 📚 Library Management System - Setup Instructions

## 🔹 Prerequisites
Before setting up the project, ensure you have the following installed:
- ✅ **.NET SDK** (Latest Version)
- ✅ **SQL Server** & **SQL Server Management Studio (SSMS)**
- ✅ **Visual Studio 2022+** (with .NET desktop development)
- ✅ **Git** *(optional, for version control)*

---

## 🔹 Configure the Database Connection
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

## 🔹 Configure Email Credentials
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

## 🔹 Run Database Migrations
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

## 🔹 Running the Application
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

## 🔹 Default Login Credentials
| Role      | Username        | Password  |
|-----------|---------------|-----------|
| **Admin** | `salemgamall`  | `admin`   |
| **Member**| `ahmedMohamed` | `member`  |
| **Librarian** | `malak` | `librarian`  |

---

## 🔹 Troubleshooting
- ❗ **If emails are not sent:** Check **SMTP settings** and ensure your email provider allows outgoing emails.
- ❗ **If the database does not connect:** Verify the **SQL Server instance** and credentials.
- ❗ **If the console app does not run automatically:** Consider using **Windows Task Scheduler**.

---

# 📚 Library Management System - Features Document

## 🌇 Introduction
The Library Management System is designed to streamline library operations, manage books and users efficiently, and ensure smooth borrowing and returning processes. It aims to improve user experience and enhance administrative control.

## 👥 User Management
- Register new users (students/staff).
- Edit user details (name, email, role).
- View user borrowing history.

## 📚 Book Management
- Add new books with title, author, category, and ISBN.
- Edit book details (title, author, year, category).
- Categorize books for easier search and organization.
- Track book availability status (available/borrowed).

## 🔄 Borrowing and Returning Books
- Borrow books with a set due date.
- Return books and update availability instantly.

## 📊 Reports and Logs
- Generate detailed reports for:
  - Available books.
  - Borrowed books.
  - Overdue books.
  - Active users.
- Log user actions (borrow, return).
- Export reports to CSV or PDF.

## 📧 Email Reminder System
- Send automatic email reminders for:
  - Due date approaching.

## 🔔 Notification System
- Internal notifications for:
  - Overdue book alerts.

## 📲 QR Code Support
- Generate QR codes for each book.
- Scan QR codes for fast borrowing and returning.

## 🔍 Search and Filter
- Search books by title, author, category, or ISBN.
- Filter books by:
  - Availability (available/borrowed).
  - Category.

## 🔒 User Roles and Permissions
- **Admin:** Full system control (manage books, users).
- **Librarian:** Manage books, reports, and user log actions.
- **Member:** View books, borrow, return.
