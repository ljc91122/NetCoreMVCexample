A movie list example for .NET Core MVC on MacOS

The code is using SQLite database.

If it says "no such table Movie"

run the following commands in commandline :

dotnet ef migrations add InitialCreate
dotnet ef database update
