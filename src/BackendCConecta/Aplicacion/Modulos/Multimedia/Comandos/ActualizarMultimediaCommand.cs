using MediatR;
using BackendCConecta.Aplicacion.Modulos.Multimedia.DTOs;
using System;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos
{
    public class ActualizarMultimediaCommand : IRequest<MultimediaDto>
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
