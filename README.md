# BackendCConecta
Backend para la plataforma Cusco Conecta

## Esquema de hashing de contraseñas

Las contraseñas se almacenan utilizando PBKDF2 con un formato que incluye los
parámetros del algoritmo para permitir futuras migraciones. El esquema actual es:

```
iteraciones.prf.salt.hash
```

- `iteraciones`: número de iteraciones utilizadas (por defecto 100 000).
- `prf`: función de derivación, actualmente `HMACSHA256`.
- `salt`: valor aleatorio en Base64.
- `hash`: resultado PBKDF2 en Base64.

Los valores antiguos con el formato anterior `salt.hash` siguen siendo válidos y
asumen 10 000 iteraciones y `HMACSHA256` como función de derivación.

## Construcción y ejecución

### Cambios realizados

- Se dejó una única solución válida (`BackendCConecta/BackendCConecta.sln`) y se
  eliminó un archivo `.sln` duplicado.
- Se limpió el repositorio quitando artefactos de compilación y archivos de
  usuario. Se agregó un `.gitignore` que excluye `bin/`, `obj/` y
  `*.csproj.user`.
- El archivo de proyecto ahora contiene únicamente la configuración requerida
  del SDK y `TargetFramework`.
- `Properties/launchSettings.json` se simplificó a un único perfil `https` con
  las URLs `https://localhost:5001` y `http://localhost:5000` y el entorno de
  desarrollo configurado.

### Instrucciones de build

Desde la carpeta `BackendCConecta` (raíz de la solución):

```bash
dotnet restore
dotnet clean
dotnet build -c Debug
```

El resultado esperado es el ejecutable
`BackendCConecta/bin/Debug/net8.0/BackendCConecta.exe`.

> Nota: en el entorno de esta evaluación el SDK de .NET no está disponible,
> por lo que los comandos anteriores no pudieron ejecutarse (`command not
> found: dotnet`). Asegúrate de tener instalado el SDK de .NET 8 para compilar
> y ejecutar la aplicación.

