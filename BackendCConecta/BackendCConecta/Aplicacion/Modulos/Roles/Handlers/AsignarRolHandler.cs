using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using BackendCConecta.Aplicacion.InterfacesGenerales;
using BackendCConecta.Aplicacion.Modulos.Roles.Comandos;
using BackendCConecta.Aplicacion.Modulos.Roles.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Roles.Handlers
{
    /// <summary>
    /// Maneja la asignación de roles a los usuarios.
    /// </summary>
    public class AsignarRolHandler : IRequestHandler<AsignarRolCommand, bool>
    {
        private readonly IRolCommandService _rolCommandService;
        private readonly ICurrentUserService _currentUser;

        public AsignarRolHandler(IRolCommandService rolCommandService, ICurrentUserService currentUser)
        {
            _rolCommandService = rolCommandService;
            _currentUser = currentUser;
        }

        public async Task<bool> Handle(AsignarRolCommand request, CancellationToken cancellationToken)
        {
            if (!_currentUser.IsInRole("administrador"))
            {
                throw new UnauthorizedAccessException("Usuario sin permisos para asignar roles.");
            }

            return await _rolCommandService.AsignarRolAsync(request.IdDatosUsuario, request.IdRol);
        }
    }
}

