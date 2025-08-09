using BackendCConecta.Dominio.Entidades.Ubicaciones;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Dominio.Repositorios;

public interface ILugaresReferenciaRepository
{
    Task<LugaresReferencia?> ObtenerPorIdAsync(int id, CancellationToken cancellationToken = default);
    Task<IEnumerable<LugaresReferencia>> ListarAsync(CancellationToken cancellationToken = default);
    Task InsertarAsync(LugaresReferencia entidad, CancellationToken cancellationToken = default);
    Task ActualizarAsync(LugaresReferencia entidad, CancellationToken cancellationToken = default);
    Task EliminarAsync(LugaresReferencia entidad, CancellationToken cancellationToken = default);
}
