using System;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.DTOs
{
    public record HistorialesDto(int Id, string Descripcion, string Estado, DateTime FechaCreacion);
}
