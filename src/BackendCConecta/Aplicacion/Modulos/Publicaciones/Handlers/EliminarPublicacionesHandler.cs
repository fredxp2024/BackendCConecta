using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Handlers
{
    public class EliminarPublicacionesHandler : IRequestHandler<EliminarPublicacionesCommand, bool>
    {
        private readonly IPublicacionesService _publicacionesService;

        public EliminarPublicacionesHandler(IPublicacionesService publicacionesService)
        {
            _publicacionesService = publicacionesService;
        }

        public async Task<bool> Handle(EliminarPublicacionesCommand request, CancellationToken cancellationToken)
        {
            return await _publicacionesService.EliminarPublicacionAsync(request.Id);
        }
    }
}
