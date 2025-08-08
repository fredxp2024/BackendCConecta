namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs
{

    public class ActualizarDatosUsuarioDto
    {
        public int IdDatosUsuario { get; set; }

        public string? Celular { get; set; }

        public string? Direccion { get; set; }

        public string? ImagenPerfil { get; set; }

        public string TipoUsuario { get; set; } = null!;

        public string? EstadoColaborador { get; set; }

        public string? EstadoGeneral { get; set; }

        public DateTime? FechaRegistro { get; set; }
    }
}