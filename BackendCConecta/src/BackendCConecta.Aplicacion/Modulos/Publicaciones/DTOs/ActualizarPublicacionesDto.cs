using System;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.DTOs
{
    public record ActualizarPublicacionesDto(int Id, string Titulo, string Contenido, string Estado, DateTime FechaCreacion);
}
