# API-Connected Database App

This .NET MAUI Blazor Hybrid app fetches user data from a public API, saves it to a local SQLite database, retrieves it, and displays it in the UI.

## Chosen API
- **JSONPlaceholder Users API**: A free, fake REST API returning user data in JSON.
- Endpoint: `https://jsonplaceholder.typicode.com/users`
- Documentation: [JSONPlaceholder](https://jsonplaceholder.typicode.com/)

## Features
- API Service: Fetches and deserializes JSON using HttpClient.
- Database Repository: Implements Repository Pattern with SQLite (InsertAllAsync, GetAllAsync).
- Dependency Injection: Services registered in MauiProgram.cs, injected in Razor components.
- UI: Button triggers fetch → save → read → display flow.

## Setup
1. Clone repo.
2. Open in Visual Studio 2022.
3. Build and run on simulator.

## Tech Stack
- .NET 8 MAUI Blazor Hybrid
- sqlite-net-pcl for DB
- System.Text.Json for deserialization