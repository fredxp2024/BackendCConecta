using System;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.DTOs
{
    public record CrearColaboradoresDto(int Id, string Nombre, string Estado, DateTime FechaCreacion);
}
