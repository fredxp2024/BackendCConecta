
using System.Collections.Generic;
using System.Threading.Tasks;

using BackendCConecta.Dominio.Entidades.UbicacionSistema;

namespace BackendCConecta.Dominio.Repositorios
{
    public interface IUbicacionesSistemaRepository
    {
        Task<UbicacionSistema?> ObtenerPorIdAsync(int id);
        Task<IEnumerable<UbicacionSistema>> ListarAsync();
        Task InsertarAsync(UbicacionSistema entidad);
        Task ActualizarAsync(UbicacionSistema entidad);
        Task EliminarAsync(UbicacionSistema entidad);
    }
}
