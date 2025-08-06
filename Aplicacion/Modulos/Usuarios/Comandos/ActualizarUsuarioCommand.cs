using MediatR;
using System;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos
{
    public class ActualizarUsuarioCommand : IRequest<bool>
    {
        public int IdUsuario { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? Password { get; set; }
        public string? MetodoAutenticacion { get; set; }
        public string? TipoAcceso { get; set; }
        public string? Estado { get; set; }
    }
}
