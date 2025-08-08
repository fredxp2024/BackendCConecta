using System;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.DTOs
{
    public record ActualizarColaboradoresDto(int Id, string Nombre, string Estado, DateTime FechaCreacion);
}
