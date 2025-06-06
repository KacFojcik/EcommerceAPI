CI/CD z GitHub Actions

Projekt wykorzystuje GitHub Actions do automatycznego budowania aplikacji po każdym pushu na gałąź `main`.

Konfiguracja

Plik workflow: `.github/workflows/build.yml`

Proces

1. **Trigger:** Workflow uruchamia się automatycznie po pushu na `main`
2. **Środowisko:** Ubuntu
3. **Etapy:**
   - Klonowanie repozytorium
   - Instalacja .NET SDK 8
   - Przywracanie zależności
   - Budowanie projektu
   - (Opcjonalnie) Uruchamianie testów
   
Dostęp do aplikacji
Aplikacja została wdrożona na platformie Azure App Service i jest publicznie dostępna pod adresem:

https://ecommerce-api-kfoj.azurewebsites.net
(dokumentacja Swagger)

Usługi Azure użyte w projekcie
Azure App Service – hostowanie aplikacji Web API (ASP.NET Core)

Azure SQL Database – przechowywanie danych (zamówienia, produkty)

App Service Plan (Free) – plan taryfowy hostingowy


Konfiguracja środowiska
Connection string do bazy danych przechowywany jako Application Setting w Azure (DefaultConnection)

Środowisko produkcyjne: ASPNETCORE_ENVIRONMENT = Production

Swagger działa domyślnie pod /swagger, przekierowanie z / jest zrealizowane programowo

Aplikacja korzysta z Entity Framework Core 8 i SQL Server

