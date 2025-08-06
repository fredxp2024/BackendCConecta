namespace BackendCConecta.Aplicacion.Modulos.Auth.DTOs
{

    public class TokenUsuarioDto
    {
        public int IdUsuario { get; set; }
        public string CorreoElectronico { get; set; } = string.Empty;
        public string TipoAcceso { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}