namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.DTOs
{
    public class CrearAcuerdoDto
    {
        public int IdDatosUsuario { get; set; }
        public int IdTarifaAcuerdo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int PublicacionesDisponibles { get; set; }
        public int DiasGracia { get; set; }
        public string Observaciones { get; set; } = default!;
    }
}