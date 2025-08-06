namespace BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }
        public string CorreoElectronico { get; set; } = null!;
        public string MetodoAutenticacion { get; set; } = null!;
        public string TipoAcceso { get; set; } = null!;
        public string? Estado { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
