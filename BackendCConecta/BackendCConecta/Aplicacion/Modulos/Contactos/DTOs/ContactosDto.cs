namespace BackendCConecta.Aplicacion.Modulos.Contactos.DTOs;

public record ContactosDto(
    int IdContacto,
    string Nombre,
    string Telefono,
    string Correo,
    string Estado);
