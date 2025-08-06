using MediatR;
using BackendCConecta.Aplicacion.Modulos.UbicacionSistema.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionSistema.Comandos
{
    public class ActualizarUbicacionSistemaCommand : IRequest<UbicacionSistemaDto>
    {
        public int IdUbicacion { get; set; }
        public string? Pais { get; set; }
        public string? Nivel1Region { get; set; }
        public string? Nivel2Provincia { get; set; }
        public string? Nivel3Distrito { get; set; }
        public string? Referencia { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
    }
}
