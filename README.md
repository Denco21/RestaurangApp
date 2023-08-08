# RestaurangApp

RestaurangApp är en webbapplikation skapad för att hjälpa restaurangägare att hantera sina beställningar och kunder.

Byggd med:
Blazor Server
.NET 6.0
Entity Framework Core med SQL Server som databas
Google Maps API

Installation och uppstart
Klona repot: git clone https://github.com/Denco21/RestaurangApp.git
Navigera till projektets mapp: cd RestaurangApp
Installera alla beroenden med: dotnet restore
Ange korrekt anslutningssträng i appsettings.json för SQL Server.
Migrera databasen för att skapa den nödvändiga databasstrukturen: dotnet ef database update
Lägg till dina API-nycklar med .NET Secret Manager.
Kör appen med: dotnet run
Funktioner
Hantera beställningar
Visa kunder på en karta med hjälp av Google Maps API

RestaurangApp is a web application created to help restaurant owners manage their orders and customers.

Built with:

Blazor Server
.NET 6.0
Entity Framework Core with SQL Server as the database
Google Maps API
Installation and Startup:

Clone the repository: git clone https://github.com/Denco21/RestaurangApp.git
Navigate to the project folder: cd RestaurangApp
Install all dependencies with: dotnet restore
Set the correct connection string in appsettings.json for SQL Server.
Migrate the database to create the necessary database structure: dotnet ef database update
Add your API keys using the .NET Secret Manager.
Run the app with: dotnet run
Features:

Manage orders
View customers on a map using the Google Maps API

