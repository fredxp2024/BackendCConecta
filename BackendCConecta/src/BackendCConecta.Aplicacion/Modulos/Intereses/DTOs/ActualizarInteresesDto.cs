using System;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.DTOs
{
    public record ActualizarInteresesDto(int Id, string Nombre, string Estado, DateTime FechaCreacion);
}
