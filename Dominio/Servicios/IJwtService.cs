using BackendCConecta.Dominio.Entidades.Usuarios;

namespace BackendCConecta.Dominio.Servicios
{
    public interface IJwtService
    {
        string GenerarToken(Usuario usuario);
    }
}
