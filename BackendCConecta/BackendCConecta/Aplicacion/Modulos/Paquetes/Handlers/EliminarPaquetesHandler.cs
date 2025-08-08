using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos;
using BackendCConecta.Aplicacion.Modulos.Paquetes.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Handlers
{
    public class EliminarPaquetesHandler : IRequestHandler<EliminarPaquetesCommand, bool>
    {
        private readonly IPaquetesService _paquetesService;

        public EliminarPaquetesHandler(IPaquetesService paquetesService)
        {
            _paquetesService = paquetesService;
        }

        public async Task<bool> Handle(EliminarPaquetesCommand request, CancellationToken cancellationToken)
        {
            return await _paquetesService.EliminarPaqueteAsync(request.Id);
        }
    }
}
