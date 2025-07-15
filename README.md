# 🧑‍💼 Employee Admin Portal

A simple **CRUD** application built with **ASP.NET Core Web API** using **Entity Framework Core**. This project follows a **minimal architecture** design to help beginners understand core concepts clearly and practically.

---

## 🚀 Features

- Add, view, update, and delete employees
- Built using clean and minimal code architecture
- Beginner-friendly and easy to follow

---

## 🛠️ Tech Stack & Tools Used

| Technology        | Description                          |
|-------------------|--------------------------------------|
| ASP.NET Core      | Web API Framework                    |
| EF Core           | ORM for Database Access              |
| MS SQL Server     | Relational Database                  |
| Rider             | IDE for .NET Development             |
| Beekeeper Studio  | GUI tool for managing SQL Databases  |
| Linux             | OS used for development              |

---

## 📦 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/Sonseldeep/EmployeeAdminPortal.git
cd EmployeeAdminPortal
```

### 2. Install Microsoft.EntityFrameworkCore

```bash
dotnet add package Microsoft.EntityFrameworkCore
```
### 3. Install Microsoft.EntityFrameworkCore.SqlServer

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

### 4. Install Microsoft.EntityFrameworkCore.Tools

```bash
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### 5. Create Migration

```bash
dotnet ef migrations add nameOfMigration
```
### 6. Apply Migration ( Update Database )

```bash
dotnet ef database update
```

### 7. To Build & Run 

```bash
dotnet build
dotnet run
```
