using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Historiales.Comandos;
using BackendCConecta.Aplicacion.Modulos.Historiales.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Handlers
{
    public class CambiarEstadoHistorialesHandler : IRequestHandler<CambiarEstadoHistorialesCommand, bool>
    {
        private readonly IHistorialesService _historialesService;

        public CambiarEstadoHistorialesHandler(IHistorialesService historialesService)
        {
            _historialesService = historialesService;
        }

        public async Task<bool> Handle(CambiarEstadoHistorialesCommand request, CancellationToken cancellationToken)
        {
            return await _historialesService.CambiarEstadoHistorialAsync(request);
        }
    }
}
