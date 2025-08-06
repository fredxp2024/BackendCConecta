
namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Interfaces;

public interface IDatosPersonaRepository
{
    Task CrearAsync(DatosPersona entidad);
    Task ActualizarAsync(DatosPersona entidad);
    Task EliminarAsync(int idDatosUsuario);
    Task<DatosPersona?> ObtenerPorIdAsync(int idDatosUsuario);
}
