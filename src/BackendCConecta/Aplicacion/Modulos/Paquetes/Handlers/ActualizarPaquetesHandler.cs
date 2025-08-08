using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos;
using BackendCConecta.Aplicacion.Modulos.Paquetes.DTOs;
using BackendCConecta.Aplicacion.Modulos.Paquetes.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Handlers
{
    public class ActualizarPaquetesHandler : IRequestHandler<ActualizarPaquetesCommand, PaquetesDto>
    {
        private readonly IPaquetesService _paquetesService;

        public ActualizarPaquetesHandler(IPaquetesService paquetesService)
        {
            _paquetesService = paquetesService;
        }

        public async Task<PaquetesDto> Handle(ActualizarPaquetesCommand request, CancellationToken cancellationToken)
        {
            return await _paquetesService.ActualizarPaqueteAsync(request);
        }
    }
}
