using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Historiales.Comandos;
using BackendCConecta.Aplicacion.Modulos.Historiales.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Handlers
{
    public class EliminarHistorialesHandler : IRequestHandler<EliminarHistorialesCommand, bool>
    {
        private readonly IHistorialesService _historialesService;

        public EliminarHistorialesHandler(IHistorialesService historialesService)
        {
            _historialesService = historialesService;
        }

        public async Task<bool> Handle(EliminarHistorialesCommand request, CancellationToken cancellationToken)
        {
            return await _historialesService.EliminarHistorialAsync(request.Id);
        }
    }
}
