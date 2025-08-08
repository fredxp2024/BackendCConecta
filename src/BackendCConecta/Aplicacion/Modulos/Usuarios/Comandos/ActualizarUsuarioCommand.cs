using MediatR;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos;

public class ActualizarUsuarioCommand : IRequest<UsuarioDto>
{
    public int IdUsuario { get; set; }
    public string? CorreoElectronico { get; set; }
    public string? Password { get; set; }
    public string? MetodoAutenticacion { get; set; }
    public string? TipoAcceso { get; set; }
    public string? Estado { get; set; }
}
