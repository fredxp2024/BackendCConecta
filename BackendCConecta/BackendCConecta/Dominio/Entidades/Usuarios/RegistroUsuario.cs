namespace BackendCConecta.Dominio.Entidades.Usuarios;

public class RegistroUsuario
{
    public int IdRegistroUsuario { get; set; }
    public string CorreoElectronico { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
}

