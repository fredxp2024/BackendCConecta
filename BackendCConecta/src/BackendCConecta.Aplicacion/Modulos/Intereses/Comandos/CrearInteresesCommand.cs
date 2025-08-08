using MediatR;
using BackendCConecta.Aplicacion.Modulos.Intereses.DTOs;
using System;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Comandos
{
    public class CrearInteresesCommand : IRequest<InteresesDto>
    {
        public string Nombre { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
