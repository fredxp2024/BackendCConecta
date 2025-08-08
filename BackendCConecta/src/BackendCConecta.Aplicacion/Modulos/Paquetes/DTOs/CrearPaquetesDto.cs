using System;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.DTOs
{
    public record CrearPaquetesDto(int Id, string Nombre, string Estado, DateTime FechaCreacion);
}
