using System.Threading;
using System.Threading.Tasks;
using MediatR;
using BackendCConecta.Aplicacion.Modulos.Empresas.Comandos;
using BackendCConecta.Aplicacion.Modulos.Empresas.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Handlers
{
    public class EliminarEmpresasHandler : IRequestHandler<EliminarEmpresasCommand, bool>
    {
        private readonly IEmpresasService _empresasService;

        public EliminarEmpresasHandler(IEmpresasService empresasService)
        {
            _empresasService = empresasService;
        }

        public async Task<bool> Handle(EliminarEmpresasCommand request, CancellationToken cancellationToken)
        {
            return await _empresasService.EliminarEmpresasAsync(request.IdEmpresa);
        }
    }
}
