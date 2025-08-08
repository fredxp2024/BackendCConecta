using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Handlers
{
    public class CambiarEstadoColaboradoresHandler : IRequestHandler<CambiarEstadoColaboradoresCommand, bool>
    {
        private readonly IColaboradoresService _colaboradoresService;

        public CambiarEstadoColaboradoresHandler(IColaboradoresService colaboradoresService)
        {
            _colaboradoresService = colaboradoresService;
        }

        public async Task<bool> Handle(CambiarEstadoColaboradoresCommand request, CancellationToken cancellationToken)
        {
            return await _colaboradoresService.CambiarEstadoColaboradorAsync(request);
        }
    }
}
