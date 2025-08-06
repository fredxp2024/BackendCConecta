using MediatR;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;
using System;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos
{
    public class RegistrarUsuarioCommand : IRequest<UsuarioDto>
    {
        public string CorreoElectronico { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string MetodoAutenticacion { get; set; } = null!;
        public string TipoAcceso { get; set; } = null!;
        public DateTime? FechaRegistro { get; set; } = DateTime.UtcNow;
        public string? Estado { get; set; } = "activo";
    }
}
