using BackendCConecta.Aplicacion.InterfacesGenerales;
using BackendCConecta.Dominio.Entidades.Usuarios;

namespace BackendCConecta.Dominio.Repositorios;

/// <summary>
/// Contrato para las operaciones específicas de usuarios.
/// </summary>
public interface IUsuarioRepository : IRepositorioGenerico<Usuario>
{
    /// <summary>
    /// Obtiene un usuario por su correo electrónico.
    /// </summary>
    /// <param name="correo">Correo del usuario.</param>
    /// <param name="cancellationToken">Token de cancelación.</param>
    Task<Usuario?> ObtenerPorCorreoAsync(string correo, CancellationToken cancellationToken = default);
}
