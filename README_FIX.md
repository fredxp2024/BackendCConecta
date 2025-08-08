# BackendCConecta Build Notes

## Dependencias

| Paquete | Antes | Después |
| --- | --- | --- |
| FluentValidation | 11.9.0 | 11.11.0 |
| FluentValidation.AspNetCore | 11.3.1 | 11.3.1 |

El resto de dependencias (AutoMapper, MediatR, Microsoft.* 8.x, etc.) permanecen sin cambios.

## Feeds NuGet
- Única fuente: `https://api.nuget.org/v3/index.json`
- Fuentes locales de Visual Studio deshabilitadas

## Comandos
```bash
dotnet restore --no-cache
dotnet build -c Debug -v minimal
dotnet run --launch-profile https
```
