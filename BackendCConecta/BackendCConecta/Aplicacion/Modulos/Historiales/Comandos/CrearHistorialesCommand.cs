using MediatR;
using BackendCConecta.Aplicacion.Modulos.Historiales.DTOs;
using System;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Comandos
{
    public class CrearHistorialesCommand : CrearHistorialesDto, IRequest<HistorialesDto>
    {
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
