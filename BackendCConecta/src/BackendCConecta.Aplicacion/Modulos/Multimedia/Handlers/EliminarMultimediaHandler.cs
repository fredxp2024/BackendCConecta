using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Handlers
{
    public class EliminarMultimediaHandler : IRequestHandler<EliminarMultimediaCommand, bool>
    {
        private readonly IMultimediaService _multimediaService;

        public EliminarMultimediaHandler(IMultimediaService multimediaService)
        {
            _multimediaService = multimediaService;
        }

        public async Task<bool> Handle(EliminarMultimediaCommand request, CancellationToken cancellationToken)
        {
            return await _multimediaService.EliminarMultimediaAsync(request.Id);
        }
    }
}
