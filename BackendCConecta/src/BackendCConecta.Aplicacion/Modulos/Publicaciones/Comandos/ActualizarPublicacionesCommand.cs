using MediatR;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.DTOs;
using System;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos
{
    public class ActualizarPublicacionesCommand : IRequest<PublicacionesDto>
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
