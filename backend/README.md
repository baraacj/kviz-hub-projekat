# KvizHub Backend Skeleton

Minimal ASP.NET Core 7 Web API skeleton for KvizHub.

## Run locally

1. Ensure PostgreSQL is running (example Docker):
   docker run --name kvizhub-db -e POSTGRES_PASSWORD=postgres -e POSTGRES_DB=kvizhub -p 5432:5432 -d postgres:15

2. Update `appsettings.json` if needed.

3. From project folder:
   dotnet restore
   dotnet ef database update
   dotnet run
