using System;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.DTOs
{
    public record ActualizarPaquetesDto(int Id, string Nombre, string Estado, DateTime FechaCreacion);
}
