using MediatR;
using System;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos
{
    public class CrearDatosUsuarioCommand : IRequest<int>
    {
        public int IdUsuario { get; set; }
        public string? Celular { get; set; }
        public string? Direccion { get; set; }
        public string? ImagenPerfil { get; set; }
        public string TipoUsuario { get; set; } = null!;
        public string? EstadoColaborador { get; set; }
        public string? EstadoGeneral { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
