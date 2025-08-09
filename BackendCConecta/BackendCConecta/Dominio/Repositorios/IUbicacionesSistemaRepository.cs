using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Dominio.Entidades.Ubicaciones;

namespace BackendCConecta.Dominio.Repositorios;

public interface IUbicacionesSistemaRepository
{
    Task<UbicacionSistema?> ObtenerPorIdAsync(int id, CancellationToken cancellationToken = default);
    Task<IEnumerable<UbicacionSistema>> ListarAsync(CancellationToken cancellationToken = default);
    Task InsertarAsync(UbicacionSistema entidad, CancellationToken cancellationToken = default);
    Task ActualizarAsync(UbicacionSistema entidad, CancellationToken cancellationToken = default);
    Task EliminarAsync(UbicacionSistema entidad, CancellationToken cancellationToken = default);
}
