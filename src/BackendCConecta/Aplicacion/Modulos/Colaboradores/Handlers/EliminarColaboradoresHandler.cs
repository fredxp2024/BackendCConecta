using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Handlers
{
    public class EliminarColaboradoresHandler : IRequestHandler<EliminarColaboradoresCommand, bool>
    {
        private readonly IColaboradoresService _colaboradoresService;

        public EliminarColaboradoresHandler(IColaboradoresService colaboradoresService)
        {
            _colaboradoresService = colaboradoresService;
        }

        public async Task<bool> Handle(EliminarColaboradoresCommand request, CancellationToken cancellationToken)
        {
            return await _colaboradoresService.EliminarColaboradorAsync(request.Id);
        }
    }
}
