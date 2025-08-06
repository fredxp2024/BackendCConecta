

using BackendCConecta.Dominio.Entidades.Usuarios;

namespace BackendCConecta.Dominio.Repositorios
{
    public interface IUsuarioRepository
    {

        Task<Usuario?> ObtenerPorCorreoAsync(string correo);

        Task ActualizarAsync(Usuario usuario);

    }
}