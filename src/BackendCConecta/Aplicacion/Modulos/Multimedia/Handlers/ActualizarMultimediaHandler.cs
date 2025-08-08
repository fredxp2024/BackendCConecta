using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos;
using BackendCConecta.Aplicacion.Modulos.Multimedia.DTOs;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Handlers
{
    public class ActualizarMultimediaHandler : IRequestHandler<ActualizarMultimediaCommand, MultimediaDto>
    {
        private readonly IMultimediaService _multimediaService;

        public ActualizarMultimediaHandler(IMultimediaService multimediaService)
        {
            _multimediaService = multimediaService;
        }

        public async Task<MultimediaDto> Handle(ActualizarMultimediaCommand request, CancellationToken cancellationToken)
        {
            return await _multimediaService.ActualizarMultimediaAsync(request);
        }
    }
}
