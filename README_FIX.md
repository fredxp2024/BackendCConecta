# BackendCConecta Build Notes

## Dependencias
- AutoMapper.Extensions.Microsoft.DependencyInjection 12.0.1
- FluentValidation.AspNetCore 11.3.1
- MediatR 11.1.0
- MediatR.Extensions.Microsoft.DependencyInjection 11.1.0
- Microsoft.AspNetCore.Authentication.JwtBearer 8.0.19
- Microsoft.AspNetCore.OpenApi 8.0.17
- Microsoft.EntityFrameworkCore 8.0.17
- Microsoft.EntityFrameworkCore.Design 8.0.17
- Microsoft.EntityFrameworkCore.SqlServer 8.0.17
- Microsoft.EntityFrameworkCore.Tools 8.0.17
- Microsoft.Extensions.Options.ConfigurationExtensions 8.0.0
- Swashbuckle.AspNetCore 6.6.2
- System.IdentityModel.Tokens.Jwt 8.13.0

Todas las referencias `Microsoft.*` se mantienen en la serie 8.x.

## Feeds NuGet
- Unica fuente: `https://api.nuget.org/v3/index.json`
- Fuentes locales de Visual Studio deshabilitadas

## Comandos
```bash
dotnet restore --no-cache
dotnet clean
dotnet build -c Debug -v minimal
```

### Ejecución
Perfil HTTPS configurado en `src/BackendCConecta/Properties/launchSettings.json`.
Ejecutar con `dotnet run --project src/BackendCConecta --launch-profile https` o F5 desde el IDE.
