using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Comandos;
using BackendCConecta.Dominio.Entidades.Ubicaciones;
using BackendCConecta.Dominio.Repositorios;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Handlers
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

        private static void ValidarExistencia(UbicacionSistema? entidad, int id)
        {
            if (entidad == null)
                throw new KeyNotFoundException($"No se encontró la ubicación con ID {id}.");
        }
    }
}
