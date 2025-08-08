using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Intereses.Comandos;
using BackendCConecta.Aplicacion.Modulos.Intereses.DTOs;
using BackendCConecta.Aplicacion.Modulos.Intereses.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Handlers
{
    public class CrearInteresesHandler : IRequestHandler<CrearInteresesCommand, InteresesDto>
    {
        private readonly IInteresesService _interesesService;

        public CrearInteresesHandler(IInteresesService interesesService)
        {
            _interesesService = interesesService;
        }

        public async Task<InteresesDto> Handle(CrearInteresesCommand request, CancellationToken cancellationToken)
        {
            return await _interesesService.CrearInteresAsync(request);
        }
    }
}
