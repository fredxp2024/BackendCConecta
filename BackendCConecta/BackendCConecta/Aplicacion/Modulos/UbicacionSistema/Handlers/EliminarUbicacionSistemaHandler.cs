using MediatR;
using BackendCConecta.Aplicacion.Modulos.UbicacionSistema.Comandos;
using BackendCConecta.Dominio.Entidades.UbicacionSistema;
using BackendCConecta.Dominio.Repositorios;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionSistema.Handlers
{
    public class EliminarUbicacionSistemaHandler : IRequestHandler<EliminarUbicacionSistemaCommand>
    {
        private readonly IUbicacionesSistemaRepository _repository;

        public EliminarUbicacionSistemaHandler(IUbicacionesSistemaRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(EliminarUbicacionSistemaCommand request, CancellationToken cancellationToken)
        {
            var entidad = await _repository.ObtenerPorIdAsync(request.IdUbicacion);
            ValidarExistencia(entidad, request.IdUbicacion);

            await _repository.EliminarAsync(entidad);
            return Unit.Value;
        }

        private static void ValidarExistencia(UbicacionesSistema? entidad, int id)
        {
            if (entidad == null)
                throw new KeyNotFoundException($"No se encontró la ubicación con ID {id}.");
        }
    }
}
