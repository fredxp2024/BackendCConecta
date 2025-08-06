
using System.Collections.Generic;
using System.Threading.Tasks;

using BackendCConecta.Aplicacion.Modulos.UbicacionSistema.DTOs;

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
