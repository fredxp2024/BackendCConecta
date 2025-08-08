namespace BackendCConecta.Aplicacion.Modulos.Auth.DTOs
{
    public class LoginResponseDto
    {
        public int IdUsuario { get; set; }
        public string Correo { get; set; } = null!;
        public string TipoAcceso { get; set; } = null!;
        public string AccessToken { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
    }
}
