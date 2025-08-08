using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces
{
    /// <summary>
    /// Define las operaciones de consulta para la entidad Usuario.
    /// </summary>
    public interface IUsuarioQueryService
    {
        Task<UsuarioDto?> ObtenerUsuarioPorIdAsync(int id, CancellationToken cancellationToken = default);
        Task<UsuarioDto?> ObtenerUsuarioPorCorreoAsync(string correo, CancellationToken cancellationToken = default);
        Task<List<UsuarioDto>> ListarAsync(CancellationToken cancellationToken = default);
    }
}
