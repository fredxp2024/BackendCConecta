
namespace BackendCConecta.Aplicacion.InterfacesGenerales
{
    public interface IPasswordHasher
    {
        string HashearPassword(string password);
        bool VerificarPassword(string passwordPlano, string hash);
        }
}

