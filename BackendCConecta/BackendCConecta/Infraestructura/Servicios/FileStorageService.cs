using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using BackendCConecta.Aplicacion.InterfacesGenerales;

namespace BackendCConecta.Infraestructura.Servicios;


public class FileStorageService : IFileStorageService
{
    private readonly IWebHostEnvironment _env;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public FileStorageService(IWebHostEnvironment env, IHttpContextAccessor httpContextAccessor)
    {
        _env = env;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<string> GuardarArchivoAsync(string carpetaDestino, IFormFile archivo)
    {
        var nombreArchivo = $"{Guid.NewGuid()}{Path.GetExtension(archivo.FileName)}";
        var carpetaRuta = Path.Combine(_env.WebRootPath ?? "wwwroot", carpetaDestino);

        if (!Directory.Exists(carpetaRuta))
            Directory.CreateDirectory(carpetaRuta);

        var rutaCompleta = Path.Combine(carpetaRuta, nombreArchivo);

        using var stream = new FileStream(rutaCompleta, FileMode.Create);
        await archivo.CopyToAsync(stream);

        var urlBase = $"{_httpContextAccessor.HttpContext!.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}";
        var urlArchivo = Path.Combine(urlBase, carpetaDestino, nombreArchivo).Replace("\\", "/");

        return urlArchivo;
    }

    public async Task<string> EditarArchivoAsync(string carpetaDestino, IFormFile archivo, string rutaAnterior)
    {
        await EliminarArchivoAsync(rutaAnterior);
        return await GuardarArchivoAsync(carpetaDestino, archivo);
    }

    public Task EliminarArchivoAsync(string rutaArchivo)
    {
        var nombreArchivo = Path.GetFileName(rutaArchivo);
        var rutaCompleta = Path.Combine(_env.WebRootPath ?? "wwwroot", nombreArchivo);

        if (File.Exists(rutaCompleta))
            File.Delete(rutaCompleta);

        return Task.CompletedTask;
    }
}
