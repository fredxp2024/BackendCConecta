using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.DTOs;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Handlers
{
    public class CrearPublicacionesHandler : IRequestHandler<CrearPublicacionesCommand, PublicacionesDto>
    {
        private readonly IPublicacionesService _publicacionesService;

        public CrearPublicacionesHandler(IPublicacionesService publicacionesService)
        {
            _publicacionesService = publicacionesService;
        }

        public async Task<PublicacionesDto> Handle(CrearPublicacionesCommand request, CancellationToken cancellationToken)
        {
            return await _publicacionesService.CrearPublicacionAsync(request);
        }
    }
}
