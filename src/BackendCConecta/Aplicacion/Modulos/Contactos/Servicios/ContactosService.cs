using BackendCConecta.Aplicacion.Modulos.Contactos.DTOs;
using BackendCConecta.Aplicacion.Modulos.Contactos.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Servicios;

public class ContactosService : IContactosService
{
    public Task<ContactosDto> CrearContactoAsync(CrearContactosDto dto)
    {
        var contacto = new ContactosDto(0, dto.Nombre, dto.Telefono, dto.Correo, "Activo");
        return Task.FromResult(contacto);
    }

    public Task<bool> ActualizarContactoAsync(ActualizarContactosDto dto) =>
        Task.FromResult(true);

    public Task<bool> EliminarContactoAsync(int idContacto) =>
        Task.FromResult(true);

    public Task<bool> CambiarEstadoContactoAsync(int idContacto, string estado) =>
        Task.FromResult(true);
}
