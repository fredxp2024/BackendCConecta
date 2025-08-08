namespace BackendCConecta.Aplicacion.Modulos.Auth.DTOs
{
    public class LoginRequestDto
    {
        public string Correo { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
