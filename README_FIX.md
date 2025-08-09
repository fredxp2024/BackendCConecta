# BackendCConecta Build Notes

## Dependencias

| Paquete | Antes | Después |
| --- | --- | --- |
| FluentValidation | 11.9.0 | 11.11.0 |
| FluentValidation.AspNetCore | 11.3.1 | 11.8.1 |
| MediatR | 11.1.0 | 12.1.1 |
| MediatR.Extensions.Microsoft.DependencyInjection | 11.1.0 | 12.1.1 |

El resto de dependencias (AutoMapper, Microsoft.* 8.x, Swashbuckle, etc.) permanecen sin cambios.

## Feeds NuGet
- Única fuente: `https://api.nuget.org/v3/index.json`
- Fuentes locales de Visual Studio deshabilitadas

## Comandos
```bash
dotnet restore --no-cache
dotnet build -c Debug -v minimal
dotnet run --launch-profile https
```

## Notas
- Se habilitó `ImplicitUsings` y `Nullable` en los proyectos principales.
- Se agregó `GlobalUsings.cs` con imports comunes (System, MediatR, FluentValidation, etc.).
- Se normalizó el namespace de ubicaciones a `BackendCConecta.Dominio.Entidades.Ubicaciones` para evitar conflictos de nombres.
