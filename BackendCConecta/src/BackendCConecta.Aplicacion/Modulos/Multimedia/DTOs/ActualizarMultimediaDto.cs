using System;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.DTOs
{
    public record ActualizarMultimediaDto(int Id, string Url, string Estado, DateTime FechaCreacion);
}
