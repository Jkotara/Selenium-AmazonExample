# Selenium + SpecFlow (C#) Mini-Framework

A tiny, production-style starter you can show in LinkedIn **Featured** and recruiters can run locally or in CI.

## What this demonstrates
- **C# + SpecFlow + Selenium** with Page Object pattern
- Simple **BDD** feature
- **Parallel**-ready test structure
- **GitHub Actions** CI that builds and runs tests on Ubuntu
- Clean README, LICENSE, and CONTRIBUTING for professionalism

## Quickstart
```bash
dotnet --version
dotnet restore
dotnet test
```

## Project layout
```
src/
  Framework/
    Drivers/
      WebDriverFactory.cs
    Pages/
      GoogleHomePage.cs
tests/
  Features/
    GoogleSearch.feature
  Steps/
    GoogleSearchSteps.cs
  Drivers/
    Hooks.cs
.github/
  workflows/
    dotnet.yml
```

## Local config
Headless Chrome by default. Override via environment variables:
- `BROWSER=chrome|firefox`
- `HEADLESS=true|false`
