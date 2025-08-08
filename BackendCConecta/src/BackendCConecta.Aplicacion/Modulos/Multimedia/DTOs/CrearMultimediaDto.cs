using System;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.DTOs
{
    public record CrearMultimediaDto(int Id, string Url, string Estado, DateTime FechaCreacion);
}
