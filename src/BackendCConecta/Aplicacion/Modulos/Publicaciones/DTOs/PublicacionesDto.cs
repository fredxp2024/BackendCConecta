using System;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.DTOs
{
    public record PublicacionesDto(int Id, string Titulo, string Contenido, string Estado, DateTime FechaCreacion);
}
