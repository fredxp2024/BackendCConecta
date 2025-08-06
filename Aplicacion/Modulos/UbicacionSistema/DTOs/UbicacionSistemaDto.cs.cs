
namespace BackendCConecta.Aplicacion.Modulos.UbicacionSistema.DTOs
{
    public class UbicacionSistemaDto
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
