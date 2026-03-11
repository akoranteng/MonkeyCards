🐒 MonkeyCards
A clean, modular Blazor Web App built step‑by‑step with EF Core, SQLite, and Syncfusion CardView.
This project is intentionally structured to be teachable, scaffolded, and enterprise‑ready, with each feature added in its own branch.

🚀 Project Overview
MonkeyCards is a Blazor Web App that displays data using a modern, mobile‑friendly CardView UI.
The app evolves through small, focused commits that demonstrate:
- Clean architecture
- EF Core data access
- SQLite local database
- Syncfusion CardView UI components
- Modular services
- Feature‑based branching
- Curriculum‑ready documentation
This repository is designed to be a teaching asset, showing how to build a real‑world Blazor application from the ground up.

🧱 Tech Stack
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
🗂️ Repository Structure
MonkeyCards/
│   README.md
│   .gitignore
│   MonkeyCards.sln
│
└───MonkeyCards/
    │   Program.cs
    │   App.razor
    │   MonkeyCards.csproj
    │
    ├───Pages/
    ├───Components/
    ├───Data/
    ├───Services/
    └───wwwroot/
    This structure keeps the solution clean, predictable, and easy to teach.

    🌱 Branching Strategy
Each feature is added in its own branch, keeping the history clean and modular.
 🌱 Branching Strategy
Each feature is added in its own branch, keeping the history clean and modular.
|Branch  |  | Purpose
| main |  | Clean Blazor template(Starting point)
| feature/efcore-setup |  | Add EFCore + SQlite + DbContext.
| feature/monkey-entity |  | Add Monkey model
| feature/monkey-service |  | Add data service (CRUD)
| feature/cardview-list |  |Add Syncfusion + CardView UI 
| feature/crud-edit-delete |  |Add edit/delete flows 
| feature/search-filter |  | Add search + filtering
| feature/favorites |  | Add favorite toggle (⭐)


This makes the repo ideal for tutorials, workshops, or curriculum slides.

🧩 Features (Planned & Implemented)
- [ ] Blazor Web App template
- [ ] EF Core + SQLite integration
- [ ] Monkey model
- [ ] MonkeyService (CRUD)
- [ ] Syncfusion CardView list page
- [ ] Edit/Delete actions
- [ ] Search + filtering
- [ ] Favorites system










