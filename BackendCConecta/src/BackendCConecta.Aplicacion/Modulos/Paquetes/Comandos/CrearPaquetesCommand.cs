using MediatR;
using BackendCConecta.Aplicacion.Modulos.Paquetes.DTOs;
using System;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos
{
    public class CrearPaquetesCommand : IRequest<PaquetesDto>
    {
        public string Nombre { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
