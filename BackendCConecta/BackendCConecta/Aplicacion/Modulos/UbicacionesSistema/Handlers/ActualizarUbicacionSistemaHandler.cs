using AutoMapper;
using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Comandos;
using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.DTOs;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Dominio.Entidades.Ubicaciones;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Handlers
{
    public class ActualizarUbicacionSistemaHandler : IRequestHandler<ActualizarUbicacionSistemaCommand, UbicacionSistemaDto>
    {
        private readonly IUbicacionesSistemaRepository _repository;
        private readonly IMapper _mapper;

        public ActualizarUbicacionSistemaHandler(IUbicacionesSistemaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UbicacionSistemaDto> Handle(ActualizarUbicacionSistemaCommand request, CancellationToken cancellationToken)
        {
            var entidad = await _repository.ObtenerPorIdAsync(request.IdUbicacion);
            ValidarExistencia(entidad);

            entidad.Pais = request.Pais;
            entidad.Nivel1Region = request.Nivel1Region;
            entidad.Nivel2Provincia = request.Nivel2Provincia;
            entidad.Nivel3Distrito = request.Nivel3Distrito;
            entidad.Referencia = request.Referencia;
            entidad.Latitud = request.Latitud;
            entidad.Longitud = request.Longitud;

            await _repository.ActualizarAsync(entidad);

            return _mapper.Map<UbicacionSistemaDto>(entidad);
        }

        private static void ValidarExistencia(UbicacionSistema? entidad)
        {
            if (entidad == null)
                throw new KeyNotFoundException("Ubicación no encontrada.");
        }
    }
}
