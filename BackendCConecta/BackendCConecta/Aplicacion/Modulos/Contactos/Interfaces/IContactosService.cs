using BackendCConecta.Aplicacion.Modulos.Contactos.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Interfaces;

public interface IContactosService
{
    Task<ContactosDto> CrearContactoAsync(CrearContactosDto dto);
    Task<bool> ActualizarContactoAsync(ActualizarContactosDto dto);
    Task<bool> EliminarContactoAsync(int idContacto);
    Task<bool> CambiarEstadoContactoAsync(int idContacto, string estado);
}
