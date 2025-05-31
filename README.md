# ShoppingCartApplication

A simple e-commerce web application built with ASP.NET Core.

Features
User Authentication & Authorization: Using ASP.NET Core Identity for user management.

Product and Category Management: Custom routes for viewing product details and categories.

Email Services: Integration of email service (with a no-op implementation for development).

Swagger API Documentation: API documentation available at /swagger in development mode.

Session Management: Supports user sessions for up to 1 hour.

Razor Pages: Includes Razor Pages for UI components.

Setup
Database:
Ensure your DefaultConnection is configured in appsettings.json.

Dependencies:
Install required packages via NuGet (Entity Framework Core, Identity, etc.).

Run:
Launch the application using dotnet run or your IDE.

Development
Swagger UI: Available at /swagger in development mode.

Identity: Customizable password and account confirmation settings.

Routes
Product Details: /product/{id}

Category: /Category/{id?}

Home: /Home/Index (default)
