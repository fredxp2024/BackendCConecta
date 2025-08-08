using System;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.DTOs
{
    public record PaquetesDto(int Id, string Nombre, string Estado, DateTime FechaCreacion);
}
