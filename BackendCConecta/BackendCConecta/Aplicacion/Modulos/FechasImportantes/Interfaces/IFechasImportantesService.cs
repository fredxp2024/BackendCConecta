using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Interfaces;

public interface IFechasImportantesService
{
    Task<int> CrearAsync(CrearFechasImportantesCommand command);
    Task<bool> ActualizarAsync(ActualizarFechasImportantesCommand command);
    Task<bool> EliminarAsync(int idFechaImportante);
    Task<bool> CambiarEstadoAsync(int idFechaImportante, bool activo);
}
