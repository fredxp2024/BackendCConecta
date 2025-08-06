using BackendCConecta.Dominio.Entidades.Usuarios;

namespace BackendCConecta.Aplicacion.InterfacesGenerales
{
    public interface IJwtTokenGenerator
    {
        string GenerarToken(Usuario usuario);
    
    }
}
