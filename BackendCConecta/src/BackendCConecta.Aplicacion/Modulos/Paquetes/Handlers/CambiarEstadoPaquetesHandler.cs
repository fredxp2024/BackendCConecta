using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos;
using BackendCConecta.Aplicacion.Modulos.Paquetes.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Handlers
{
    public class CambiarEstadoPaquetesHandler : IRequestHandler<CambiarEstadoPaquetesCommand, bool>
    {
        private readonly IPaquetesService _paquetesService;

        public CambiarEstadoPaquetesHandler(IPaquetesService paquetesService)
        {
            _paquetesService = paquetesService;
        }

        public async Task<bool> Handle(CambiarEstadoPaquetesCommand request, CancellationToken cancellationToken)
        {
            return await _paquetesService.CambiarEstadoPaqueteAsync(request);
        }
    }
}
