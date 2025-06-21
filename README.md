# TripsSystem


Updated README.md with CRUD Operations for Categories, Cities, and Countries
markdown
# 🌍 Trip Management System

A modern ASP.NET Core web application for managing travel itineraries with full CRUD operations for trips, categories, cities, and countries.

## ✨ Features
- **Complete CRUD Operations**:
  - Trip management (Create, Read, Update, Delete)
  - Category management
  - City management
  - Country management
- **Relational Data**: Countries → Cities → Trips with Category classification
- **Three-Layer Architecture**: Clear separation of concerns
- **Dependency Injection**: Loosely coupled components
- **Responsive UI**: Bootstrap 5 with FontAwesome icons

## 🛠️ Technologies
- **Frontend**: Razor Pages, Bootstrap 5, FontAwesome
- **Backend**: ASP.NET Core 6.0
- **Database**: SQL Server
- **Architecture**: 
  - Presentation Layer (Razor Pages)
  - Business Logic Layer (Services, DTOs)
  - Data Access Layer (Repositories, EF Core)

## 🗂️ Project Structure
```plaintext
TripManagementSystem/
├── Presentation/           # UI Layer
│   ├── Pages/
│   │   ├── Categories/     # Category CRUD
│   │   ├── Cities/         # City CRUD
│   │   ├── Countries/      # Country CRUD
│   │   ├── Trips/          # Trip CRUD
│   │   └── _Layout.cshtml  # Main layout
│
├── BusinessLogic/          # Business Layer
│   ├── Services/
│   │   ├── CategoryService.cs
│   │   ├── CityService.cs
│   │   ├── CountryService.cs
│   │   └── TripService.cs
│   ├── DTOs/               # Data transfer objects
│   └── Interfaces/         # Service contracts
│
├── DataAccess/             # Data Layer
│   ├── Repositories/       # Repository implementations
│   ├── Entities/           # Domain models
│   └── Context/            # DbContext and migrations
│
└── appsettings.json        # Configuration
🚀 Getting Started
Prerequisites
.NET 6.0 SDK

SQL Server 2019+

Visual Studio 2022 or VS Code

Setup
Database Setup:

sql
-- Run the provided SQL script to create:
-- Tables: Country, City, Category, Trip
-- Sample data for all entities
Configuration:
Update connection string in appsettings.json:

json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=TripDB;Trusted_Connection=True;"
}
Dependency Injection (Program.cs):

csharp
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<ITripService, TripService>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ITripRepository, TripRepository>();
UI Setup (_Layout.cshtml):

html
<head>
  <!-- Bootstrap 5 -->
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
  
  <!-- FontAwesome -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
</head>
CRUD Endpoints
Entity	Create	Read	Update	Delete
Categories	/Categories/Create	/Categories	/Categories/Edit	/Categories/Delete
Cities	/Cities/Create	/Cities	/Cities/Edit	/Cities/Delete
Countries	/Countries/Create	/Countries	/Countries/Edit	/Countries/Delete
Trips	/Trips/Create	/Trips	/Trips/Edit	/Trips/Delete
🧩 Key Components
1. Three-Layer Architecture
Presentation Layer:

Razor Pages for UI rendering

PageModel classes handle HTTP requests

Example: Pages/Categories/Index.cshtml.cs

Business Logic Layer:

Service classes with business rules

DTOs for data transfer

Validation logic

Example service interface:

csharp
public interface ICountryService {
    Task CreateCountryAsync(CountryDTO countryDTO);
    Task UpdateCountryAsync(CountryDTO countryDTO);
    Task DeleteCountryAsync(int id);
    Task<IEnumerable<CountryDTO>> GetAllCountriesAsync();
}
Data Access Layer:

Repository pattern with EF Core

Database operations

Example repository:

csharp
public class CityRepository : ICityRepository {
    private readonly TripDbContext _context;
    public CityRepository(TripDbContext context) => _context = context;
    
    public async Task AddAsync(City city) {
        await _context.Cities.AddAsync(city);
        await _context.SaveChangesAsync();
    }
}
2. Entity Relationships
Diagram
Code








3. Dependency Injection
Constructor injection in all layers

Services registered in Program.cs

Example usage in PageModel:

csharp
public class IndexModel : PageModel {
    private readonly ICountryService _countryService;
    
    public IndexModel(ICountryService countryService) {
        _countryService = countryService;
    }
    
    public async Task OnGetAsync() {
        Countries = await _countryService.GetAllCountriesAsync();
    }
}
📝 License
MIT License - Free for personal and commercial use

🌐 Live Demo
View live demo (if available)

🙏 Acknowledgements
Bootstrap for responsive UI components

FontAwesome for icons

Entity Framework Core for data access

text

### Key Updates to README:

1. **Enhanced Features Section**:
   - Explicitly mentions CRUD for all four entities
   - Highlights relational data structure

2. **Updated Project Structure**:
   - Shows new directories for Categories, Cities, and Countries
   - Includes service and repository layers for all entities

3. **CRUD Endpoints Table**:
   - Clear reference to all available operations
   - Organized by entity type

4. **Dependency Injection Details**:
   - Shows service/repository registration in Program.cs
   - Includes constructor injection example

5. **Architecture Clarification**:
   - Explains responsibilities of each layer
   - Shows code examples for key components
   - Includes ER diagram for database relationships

6. **Implementation Guidance**:
   - Database setup instructions
   - Configuration steps
   - Endpoint references

