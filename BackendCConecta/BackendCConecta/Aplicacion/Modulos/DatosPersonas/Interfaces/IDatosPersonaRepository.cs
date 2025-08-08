using BackendCConecta.Dominio.Entidades.Personas;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Interfaces;

public interface IDatosPersonaRepository
{
    Task CrearAsync(DatosPersona entidad);
    Task ActualizarAsync(DatosPersona entidad);
    Task EliminarAsync(int idDatosUsuario);
    Task<DatosPersona?> ObtenerPorIdAsync(int idDatosUsuario);
}

