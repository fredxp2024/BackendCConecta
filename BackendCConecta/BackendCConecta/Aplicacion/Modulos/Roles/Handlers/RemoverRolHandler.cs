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
    /// Maneja la eliminación de roles asignados a los usuarios.
    /// </summary>
    public class RemoverRolHandler : IRequestHandler<RemoverRolCommand, bool>
    {
        private readonly IRolCommandService _rolCommandService;
        private readonly ICurrentUserService _currentUserService;

        public RemoverRolHandler(IRolCommandService rolCommandService, ICurrentUserService currentUserService)
        {
            _rolCommandService = rolCommandService;
            _currentUserService = currentUserService;
        }

        public async Task<bool> Handle(RemoverRolCommand request, CancellationToken cancellationToken)
        {
            if (!_currentUserService.HasRole("administrador"))
            {
                throw new UnauthorizedAccessException("Usuario sin permisos para modificar roles.");
            }

            return await _rolCommandService.RemoverRolAsync(request.IdDatosUsuario, request.IdRol);
        }
    }
}

