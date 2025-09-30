# Contributing

This demo is intentionally minimal to show code quality and project hygiene.

## Dev setup
- .NET 8 SDK
- Chrome/Chromedriver (CI uses the default GitHub image)

## Style
- Keep steps readable and short
- Avoid sleeps; prefer WebDriverWait
- Keep page objects lean; one responsibility per method
