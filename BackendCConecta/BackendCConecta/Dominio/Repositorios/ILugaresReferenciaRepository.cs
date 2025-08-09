using BackendCConecta.Dominio.Entidades.Ubicaciones;

namespace BackendCConecta.Dominio.Repositorios;

public interface ILugaresReferenciaRepository
{
    Task<LugaresReferencia?> ObtenerPorIdAsync(int id);
    Task<IEnumerable<LugaresReferencia>> ListarAsync();
    Task InsertarAsync(LugaresReferencia entidad);
    Task ActualizarAsync(LugaresReferencia entidad);
    Task EliminarAsync(LugaresReferencia entidad);
}
