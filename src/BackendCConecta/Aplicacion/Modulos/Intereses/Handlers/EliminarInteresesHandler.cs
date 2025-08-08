using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Intereses.Comandos;
using BackendCConecta.Aplicacion.Modulos.Intereses.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Handlers
{
    public class EliminarInteresesHandler : IRequestHandler<EliminarInteresesCommand, bool>
    {
        private readonly IInteresesService _interesesService;

        public EliminarInteresesHandler(IInteresesService interesesService)
        {
            _interesesService = interesesService;
        }

        public async Task<bool> Handle(EliminarInteresesCommand request, CancellationToken cancellationToken)
        {
            return await _interesesService.EliminarInteresAsync(request.Id);
        }
    }
}
