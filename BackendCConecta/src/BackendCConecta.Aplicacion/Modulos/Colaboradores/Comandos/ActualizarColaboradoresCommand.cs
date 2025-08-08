using MediatR;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.DTOs;
using System;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos
{
    public class ActualizarColaboradoresCommand : IRequest<ColaboradoresDto>
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
