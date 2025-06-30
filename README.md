# 🎬 DvdRental

A simple DVD rental management system built with ASP.NET Core and Entity Framework Core (Code First approach).

## 📦 Features

- Customer management
- Movie inventory and rental tracking
- Rental creation and return logging
- Basic reporting features
- Clean architecture with separate layers (Domain, Data, UI)
- Dockerized database support with PostgreSQL
- Swagger documentation for APIs

## 🛠 Technologies Used

- ASP.NET Core
- C#
- Entity Framework Core (Code First)
- PostgreSQL
- AutoMapper
- Swagger / OpenAPI

## 📁 Project Structure

```
DvdRental/
├── DomainLayer/     ← Domain models and interfaces
├── DataLayer/       ← DbContext, Migrations, and Repositories
├── UI/              ← Web API (Controllers and Program)
└── README.md
```

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [PostgreSQL](https://www.postgresql.org/) (if not using Docker)
- (Optional) Docker & Docker Compose

### Running the App

#### Option 1: Local Setup

```bash
git clone https://github.com/mehdihajati/DvdRental.git
cd DvdRental
dotnet ef database update
dotnet run --project UI
```

#### Option 2: Dockerized Setup

```bash
docker-compose up --build
```

> Make sure Docker is installed and running on your system.

### 🔍 API Documentation

Once running, you can access the Swagger UI at:

```
http://localhost:5000/swagger
```

## 🧪 To Do

- [ ] Add JWT authentication and authorization
- [ ] Add unit and integration tests
- [ ] Create a frontend UI (React, Blazor, or other)

## 📄 License

This project is licensed under the MIT License.

---

## 👤 About Me

**Mehdi Hajati**  
📧 [mehdihajati@gmail.com](mailto:mehdihajati@gmail.com)  
🔗 [GitHub](https://github.com/mehdihajati)
