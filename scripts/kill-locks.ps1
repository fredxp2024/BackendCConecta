taskkill /F /IM BackendCConecta.exe /T 2>$null
dotnet build-server shutdown
