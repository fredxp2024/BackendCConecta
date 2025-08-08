using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Intereses.Comandos;
using BackendCConecta.Aplicacion.Modulos.Intereses.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Handlers
{
    public class CambiarEstadoInteresesHandler : IRequestHandler<CambiarEstadoInteresesCommand, bool>
    {
        private readonly IInteresesService _interesesService;

        public CambiarEstadoInteresesHandler(IInteresesService interesesService)
        {
            _interesesService = interesesService;
        }

        public async Task<bool> Handle(CambiarEstadoInteresesCommand request, CancellationToken cancellationToken)
        {
            return await _interesesService.CambiarEstadoInteresAsync(request);
        }
    }
}
