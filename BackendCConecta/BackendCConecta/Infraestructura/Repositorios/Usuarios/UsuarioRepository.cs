using BackendCConecta.Dominio.Entidades.Usuarios;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace BackendCConecta.Infraestructura.Repositorios.Usuarios;

/// <summary>
/// Repositorio específico para operaciones sobre la entidad <see cref="Usuario"/>.
/// </summary>
public class UsuarioRepository : RepositorioGenerico<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(AppDbContext context) : base(context)
    {
    }

    /// <inheritdoc />
    public async Task<Usuario?> ObtenerPorCorreoAsync(string correo, CancellationToken cancellationToken = default)
    {
        return await _dbSet.FirstOrDefaultAsync(u => u.CorreoElectronico == correo, cancellationToken);
    }
}
