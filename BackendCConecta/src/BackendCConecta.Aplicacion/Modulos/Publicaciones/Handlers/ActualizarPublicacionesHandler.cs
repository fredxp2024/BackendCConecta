using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.DTOs;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Handlers
{
    public class ActualizarPublicacionesHandler : IRequestHandler<ActualizarPublicacionesCommand, PublicacionesDto>
    {
        private readonly IPublicacionesService _publicacionesService;

        public ActualizarPublicacionesHandler(IPublicacionesService publicacionesService)
        {
            _publicacionesService = publicacionesService;
        }

        public async Task<PublicacionesDto> Handle(ActualizarPublicacionesCommand request, CancellationToken cancellationToken)
        {
            return await _publicacionesService.ActualizarPublicacionAsync(request);
        }
    }
}
