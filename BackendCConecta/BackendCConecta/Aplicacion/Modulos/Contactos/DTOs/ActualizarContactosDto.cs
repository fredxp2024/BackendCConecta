namespace BackendCConecta.Aplicacion.Modulos.Contactos.DTOs;

public record ActualizarContactosDto(
    int IdContacto,
    string? Nombre,
    string? Telefono,
    string? Correo);
