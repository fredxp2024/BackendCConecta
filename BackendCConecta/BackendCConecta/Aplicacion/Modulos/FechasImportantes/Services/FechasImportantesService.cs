using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Services;

public class FechasImportantesService : IFechasImportantesService
{
    public Task<int> CrearAsync(CrearFechasImportantesCommand command)
    {
        return Task.FromResult(0);
    }

    public Task<bool> ActualizarAsync(ActualizarFechasImportantesCommand command)
    {
        return Task.FromResult(true);
    }

    public Task<bool> EliminarAsync(int idFechaImportante)
    {
        return Task.FromResult(true);
    }

    public Task<bool> CambiarEstadoAsync(int idFechaImportante, bool activo)
    {
        return Task.FromResult(true);
    }
}
