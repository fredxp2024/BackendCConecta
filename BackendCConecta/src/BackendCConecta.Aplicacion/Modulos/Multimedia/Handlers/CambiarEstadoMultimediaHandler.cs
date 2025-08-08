using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Handlers
{
    public class CambiarEstadoMultimediaHandler : IRequestHandler<CambiarEstadoMultimediaCommand, bool>
    {
        private readonly IMultimediaService _multimediaService;

        public CambiarEstadoMultimediaHandler(IMultimediaService multimediaService)
        {
            _multimediaService = multimediaService;
        }

        public async Task<bool> Handle(CambiarEstadoMultimediaCommand request, CancellationToken cancellationToken)
        {
            return await _multimediaService.CambiarEstadoMultimediaAsync(request);
        }
    }
}
