# tools/unlock-and-clean.ps1
$ErrorActionPreference = "SilentlyContinue"

# Intenta matar el proceso por nombre
taskkill /F /IM BackendCConecta.exe
taskkill /F /IM dotnet.exe

# Limpieza de bin/obj (Debug por defecto)
$root = Split-Path -Parent (Split-Path -Parent $MyInvocation.MyCommand.Path)
$bin = Join-Path $root "bin\Debug\net8.0"
$obj = Join-Path $root "obj\Debug\net8.0"

if (Test-Path $bin) { Remove-Item $bin -Recurse -Force }
if (Test-Path $obj) { Remove-Item $obj -Recurse -Force }

Write-Host "Procesos finalizados y carpetas Debug/net8.0 limpiadas."
