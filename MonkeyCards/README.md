# 🐒 MonkeyCards — EF Core Setup (feature/efcore-setup)

This branch establishes the full Entity Framework Core foundation for the MonkeyCards Blazor Web App.  
It includes the DbContext, SQLite configuration, initial migration, and database creation.

---

## 🚀 Milestone Summary

This milestone includes:

- Added `AppDbContext` with `DbSet<Monkey>`
- Configured EF Core with SQLite in `Program.cs`
- Added connection string in `appsettings.json`
- Created `InitialCreate` migration
- Applied migration to generate `monkeys.db`
- Verified Migrations folder and schema on GitHub

This completes the backend foundation for CRUD operations.

---

## 🧱 Project Structure (after EF Core setup)
MonkeyCards/ ├── Components/ ├── Data/ │    └── AppDbContext.cs ├── Migrations/ │    ├── 20260312174325_InitialCreate.cs │    ├── 20260312174325_InitialCreate.Designer.cs │    └── AppDbContextModelSnapshot.cs ├── Models/ │    └── Monkey.cs ├── Program.cs ├── appsettings.json └── MonkeyCards.csproj
MonkeyCards/ ├── Components/ ├── Data/ │    └── AppDbContext.cs ├── Migrations/ │    ├── 20260312174325_InitialCreate.cs │    ├── 20260312174325_InitialCreate.Designer.cs │    └── AppDbContextModelSnapshot.cs ├── Models/ │    └── Monkey.cs ├── Program.cs ├── appsettings.json └── MonkeyCards.csproj


---

## 🗄️ EF Core Migration Commands

### **Visual Studio (Package Manager Console)**

| Scenario | Command | Example | Notes |
|---------|---------|---------|-------|
| Inside Visual Studio | `Add-Migration` | `Add-Migration InitialCreate` | Windows‑only, IDE‑integrated |
| Apply migration | `Update-Database` | `Update-Database` | Creates/updates database |

### **Terminal / CLI (cross‑platform)**

| Scenario | Command | Example | Notes |
|---------|---------|---------|-------|
| Add migration | `dotnet ef migrations add` | `dotnet ef migrations add InitialCreate` | Works on Windows/macOS/Linux |
| Apply migration | `dotnet ef database update` | `dotnet ef database update` | Required for automation/CI |

**Rule of thumb:**  
> Use **Add-Migration** inside Visual Studio.  
> Use **dotnet ef** in any terminal.

---

## 🧪 How to Reproduce This Milestone

### 1. Install EF Install Core tools (if needed)
     dotnet tool install --global dotnet-ef

     
### 2. Add the migration
dotnet ef migrations add InitialCreate
dotnet ef database update

### 3. Apply the migration


---

## ⚠️ GOTCHAS & Lessons Learned

### **1. Nested Solution/Project Folder Confusion**
Visual Studio created:

If you commit from the **outer** folder, Git will NOT include:

- Migrations folder  
- Models  
- Data  
- appsettings.json  
- Program.cs  

**Fix:**  
Always commit from the folder that contains the `.csproj`.

**Rule:**  
> If you don’t see a `.csproj` in the folder, don’t commit from it.

---

### **2. Wrong Connection String Filename**

---

### **3. Running EF Commands in the Wrong Folder**
If you see:No project was found here
No project was found here

You’re not in the folder with the `.csproj`.

Run:dir *.csproj
 t


