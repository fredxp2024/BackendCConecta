using System;

namespace BackendCConecta.Aplicacion.Modulos.Staff.DTOs
{
    public record ActualizarStaffDto(int Id, string Nombre, string Estado, DateTime FechaCreacion);
}
