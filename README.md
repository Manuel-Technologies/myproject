# C# Backend, App & Embedded Systems Lab

A personal, ever-growing repository where I practice and deepen my skills in professional **C# backend engineering**, cross-platform **.NET MAUI** applications, **IoT**, and **embedded systems** — all coded almost exclusively from my phone.

Yes, every line here was written, built, and debugged on mobile using tools like:
- **a-Shell** / **a-Shell mini** (iOS)
- **Termux** (Android)
- **CodeServer** / **GitHub Mobile** / **GitJournal**
- Remote VS Code via code-server or Gitpod when needed

This repo is my real-world playground for production-grade patterns while staying completely mobile.

### Main Focus Areas

| Folder                      | Description                                                                 |
|-----------------------------|-----------------------------------------------------------------------------|
| `Backend/`                  | Clean Architecture APIs, Minimal APIs, CQRS, MediatR, Vertical Slice, gRPC |
| `MAUI/`                     | .NET MAUI cross-platform apps (Android, iOS, Windows) with MVVM, CommunityToolkit |
| `IoT-Embedded/`             | nanoFramework, Meadow, TinyCLR, ESP32 + C#, Azure IoT Hub examples          |
| `MessageBrokers/`           | RabbitMQ, Azure Service Bus, MassTransit examples                           |
| `Databases/`                | EF Core migrations, Dapper, Marten, PostgreSQL, SQLite, Cosmos DB      |
| `Authentication/`           | JWT, Identity, Azure AD B2C, IdentityServer templates                       |
| `Testing/`                  | xUnit, FluentAssertions, Testcontainers, integration tests                  |
| `CI-CD/`                    | GitHub Actions workflows for build → test → publish MAUI & API           |
| `Design-Patterns/`          | Real-world implementations (Repository, Mediator, Factory, etc.)           |
| `Performance/`              | BenchmarkDotNet, memory profiling, Span<T>, Source Generators               |

### Tech Stack (current as of 2025)
- **.NET 8 & .NET 9** (LTS + preview)
- **C# 13**
- **.NET MAUI** (Android, iOS, Mac Catalyst, Windows)
- **.NET nanoFramework** & **Meadow** for true embedded C#
- **PostgreSQL**, **SQLite**, **Cosmos DB**, **Redis**
- **Docker** & **Testcontainers**
- **Azure** (App Service, Functions, IoT Hub, Static Web Apps)

### How to run (even on phone)
Most projects include a simple script:
```bash
./run.sh        # builds and runs with dotnet
./debug.sh      # attaches remote debugger if needed
