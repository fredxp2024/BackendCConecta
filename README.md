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
