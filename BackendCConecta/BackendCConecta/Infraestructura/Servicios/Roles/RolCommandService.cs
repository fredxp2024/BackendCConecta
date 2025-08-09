using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Roles.Interfaces;

namespace BackendCConecta.Infraestructura.Servicios.Roles;

public class RolCommandService : IRolCommandService
{
    public Task<bool> AsignarRolAsync(int idDatosUsuario, int idRol)
        => Task.FromResult(true);

    public Task<bool> RemoverRolAsync(int idDatosUsuario, int idRol)
        => Task.FromResult(true);
}
