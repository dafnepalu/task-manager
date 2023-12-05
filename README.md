# task-manager

## Description
This project is a Blazor web application (server-side) built with OAuth 2.0 and OIDC for secure authentication. The app functions as a straightforward task manager, enabling authenticated users to seamlessly view, add, edit, and delete tasks within a user-friendly interface.

## Key Features
* Robust user authentication using OAuth 2.0 and OIDC, complementing ASP.NET Core's Identity membership system.
* Task management functionalities, including viewing, adding, editing, and deleting tasks effortlessly.
* Intuitive and responsive user interface with Toast notifications, ensuring immediate and user-friendly feedback for every action

## Tech Stack
### Framework & Language:
- Blazor (server-side) with .NET Core 8.0
- C# for backend logic
  
### Authentication & Authorization:
- OAuth 2.0 & OIDC (OpenID Connect)
- ASP.NET Core Identity for user management

### Data Management:
- Entity Framework Core and SQL Server

### User Interface & Styling:
- Bootstrap for responsive and intuitive UI components

## Project Architecture
### Service Interface & Implementation Structure
This project follows a structured design pattern where service interfaces and their corresponding implementations are utilized for better modularity and maintainability. By separating service interfaces from their implementations, the codebase achieves a clearer separation of concerns and facilitates unit testing.

## How to Use
1. Clone the repository to your local machine.
2. Build and run the Blazor web application.
3. Register as a user (for Google Authentication access, please [email me](mailto:paludafne@gmail.com) to add your Google account to the list of Test Users)
4. Confirm your registration.
5. Log in to the application.
6. Access the Tasks section via the Navigation Bar.
7. Effortlessly create, edit, and delete tasks to manage your workflow seamlessly.
