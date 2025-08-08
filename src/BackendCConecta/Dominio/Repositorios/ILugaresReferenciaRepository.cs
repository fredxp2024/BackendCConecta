using BackendCConecta.Dominio.Entidades.UbicacionSistema;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendCConecta.Dominio.Repositorios;

public interface ILugaresReferenciaRepository
{
    Task<LugaresReferencia?> ObtenerPorIdAsync(int id);
    Task<IEnumerable<LugaresReferencia>> ListarAsync();
    Task InsertarAsync(LugaresReferencia entidad);
    Task ActualizarAsync(LugaresReferencia entidad);
    Task EliminarAsync(LugaresReferencia entidad);
}
