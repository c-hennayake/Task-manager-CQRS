# Task Manager API

A Task Management REST API built with ASP.NET Core using Clean Architecture, CQRS, MediatR, Entity Framework Core, FluentValidation, and SQL Server.

## Features

* Create Task
* Get All Tasks
* Get Task By Id
* Update Task
* Delete Task
* Pagination
* Filtering
* CQRS Pattern
* MediatR
* Repository Pattern
* Unit of Work
* FluentValidation
* Validation Pipeline Behavior
* Global Exception Handling
* Custom Exceptions

## Technologies Used

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* MediatR
* FluentValidation
* Clean Architecture
* CQRS

## Project Structure

```text
TaskManager.Api
TaskManager.Application
TaskManager.Domain
TaskManager.Infrastructure
```

## API Endpoints

### Create Task

POST /api/tasks

### Get All Tasks

GET /api/tasks

### Get Task By Id

GET /api/tasks/{id}

### Update Task

PUT /api/tasks/{id}

### Delete Task

DELETE /api/tasks/{id}

## Pagination & Filtering

Get first page:

GET /api/tasks?pageNumber=1&pageSize=10

Search by title:

GET /api/tasks?search=Task

Filter completed tasks:

GET /api/tasks?isCompleted=true

Combined:

GET /api/tasks?pageNumber=1&pageSize=10&search=Task&isCompleted=false

## Getting Started

### Clone Repository

git clone <repository-url>

### Update Connection String

Update appsettings.json:

{
"ConnectionStrings": {
"DefaultConnection": "your-sql-server-connection-string"
}
}

### Apply Database Migration

dotnet ef database update

### Run Application

dotnet run

## Architecture

The application follows Clean Architecture principles.

* API Layer: Controllers and Middleware
* Application Layer: CQRS Commands, Queries, Validators, DTOs
* Domain Layer: Entities
* Infrastructure Layer: EF Core, Repositories, Unit of Work

## Future Improvements

* JWT Authentication
* Role-Based Authorization
* Angular Frontend
* Serilog Logging
* Docker Support
* Deployment Pipeline
