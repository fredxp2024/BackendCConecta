namespace BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs
{
    public class CrearUsuarioDto
    {
        public string CorreoElectronico { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string MetodoAutenticacion { get; set; } = null!;
        public string TipoAcceso { get; set; } = null!;
    }
}
