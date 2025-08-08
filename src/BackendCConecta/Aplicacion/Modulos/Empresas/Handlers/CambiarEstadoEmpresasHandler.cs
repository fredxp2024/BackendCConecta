using System.Threading;
using System.Threading.Tasks;
using MediatR;
using BackendCConecta.Aplicacion.Modulos.Empresas.Comandos;
using BackendCConecta.Aplicacion.Modulos.Empresas.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Handlers
{
    public class CambiarEstadoEmpresasHandler : IRequestHandler<CambiarEstadoEmpresasCommand, bool>
    {
        private readonly IEmpresasService _empresasService;

        public CambiarEstadoEmpresasHandler(IEmpresasService empresasService)
        {
            _empresasService = empresasService;
        }

        public async Task<bool> Handle(CambiarEstadoEmpresasCommand request, CancellationToken cancellationToken)
        {
            return await _empresasService.CambiarEstadoEmpresasAsync(request.IdEmpresa, request.Estado);
        }
    }
}
