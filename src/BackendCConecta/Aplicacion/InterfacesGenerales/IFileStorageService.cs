namespace BackendCConecta.Aplicacion.InterfacesGenerales
{
public interface IFileStorageService
{
    Task<string> GuardarArchivoAsync(string carpetaDestino, IFormFile archivo);
    Task EliminarArchivoAsync(string rutaArchivo);
    Task<string> EditarArchivoAsync(string carpetaDestino, IFormFile archivo, string rutaAnterior);
}
}