using MediatR;
using BackendCConecta.Aplicacion.Modulos.Staff.DTOs;
using System;

namespace BackendCConecta.Aplicacion.Modulos.Staff.Comandos
{
    public class CrearStaffCommand : IRequest<StaffDto>
    {
        public string Nombre { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
