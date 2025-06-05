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