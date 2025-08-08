using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Handlers
{
    public class CambiarEstadoPublicacionesHandler : IRequestHandler<CambiarEstadoPublicacionesCommand, bool>
    {
        private readonly IPublicacionesService _publicacionesService;

        public CambiarEstadoPublicacionesHandler(IPublicacionesService publicacionesService)
        {
            _publicacionesService = publicacionesService;
        }

        public async Task<bool> Handle(CambiarEstadoPublicacionesCommand request, CancellationToken cancellationToken)
        {
            return await _publicacionesService.CambiarEstadoPublicacionAsync(request);
        }
    }
}
