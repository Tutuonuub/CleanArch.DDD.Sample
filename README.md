# CleanArch.DDD.Sample
Projeto exemplo demonstrando Clean Architecture + DDD com ASP.NET Core MVC, Entity Framework Core e SQL Server.

Instruções:
1. Extraia o zip.
2. Ajuste a connection string em src/CleanArch.WebUI/appsettings.json ("DefaultConnection").
3. Execute `dotnet restore` na solution folder, depois `dotnet ef migrations add InitialCreate --project src/CleanArch.Infrastructure --startup-project src/CleanArch.WebUI` e `dotnet ef database update --project src/CleanArch.Infrastructure --startup-project src/CleanArch.WebUI`.
4. Rode `dotnet run --project src/CleanArch.WebUI` para iniciar a aplicação (por padrão abrirá /Products).
