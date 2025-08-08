using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Intereses.Comandos;
using BackendCConecta.Aplicacion.Modulos.Intereses.DTOs;
using BackendCConecta.Aplicacion.Modulos.Intereses.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Handlers
{
    public class ActualizarInteresesHandler : IRequestHandler<ActualizarInteresesCommand, InteresesDto>
    {
        private readonly IInteresesService _interesesService;

        public ActualizarInteresesHandler(IInteresesService interesesService)
        {
            _interesesService = interesesService;
        }

        public async Task<InteresesDto> Handle(ActualizarInteresesCommand request, CancellationToken cancellationToken)
        {
            return await _interesesService.ActualizarInteresAsync(request);
        }
    }
}
