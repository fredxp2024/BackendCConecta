
namespace BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.DTOs
{
    public class UbicacionSistemaDto
    {
        public int IdUbicacion { get; set; }
        public string? Pais { get; set; }
        public string? Nivel1Region { get; set; }
        public string? Nivel2Provincia { get; set; }
        public string? Nivel3Distrito { get; set; }
        public string? Referencia { get; set; }
        private decimal? latitud;
        public decimal? Latitud
        {
            get => latitud;
            set => latitud = value.HasValue ? decimal.Round(value.Value, 6) : value;
        }

        private decimal? longitud;
        public decimal? Longitud
        {
            get => longitud;
            set => longitud = value.HasValue ? decimal.Round(value.Value, 6) : value;
        }
    }
}
