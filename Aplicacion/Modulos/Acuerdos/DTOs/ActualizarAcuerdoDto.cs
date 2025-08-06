namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.DTOs
{
    public class ActualizarAcuerdoDto
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int PublicacionesDisponibles { get; set; }
        public int DiasGracia { get; set; }
        public string EstadoAcuerdo { get; set; }
        public string Observaciones { get; set; }
    }
}