using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos;
using BackendCConecta.Aplicacion.Modulos.Multimedia.DTOs;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Handlers
{
    public class CrearMultimediaHandler : IRequestHandler<CrearMultimediaCommand, MultimediaDto>
    {
        private readonly IMultimediaService _multimediaService;

        public CrearMultimediaHandler(IMultimediaService multimediaService)
        {
            _multimediaService = multimediaService;
        }

        public async Task<MultimediaDto> Handle(CrearMultimediaCommand request, CancellationToken cancellationToken)
        {
            return await _multimediaService.CrearMultimediaAsync(request);
        }
    }
}
