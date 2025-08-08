using AutoMapper;
using MediatR;
using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Comandos;
using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.DTOs;
using BackendCConecta.Dominio.Entidades.UbicacionSistema;
using BackendCConecta.Dominio.Repositorios;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Handlers
{
    public class CrearUbicacionSistemaHandler : IRequestHandler<CrearUbicacionSistemaCommand, UbicacionSistemaDto>
    {
        private readonly IUbicacionesSistemaRepository _repository;
        private readonly IMapper _mapper;

        public CrearUbicacionSistemaHandler(IUbicacionesSistemaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UbicacionSistemaDto> Handle(CrearUbicacionSistemaCommand request, CancellationToken cancellationToken)
        {
            var entidad = new UbicacionSistema
            {
                Pais = request.Pais,
                Nivel1Region = request.Nivel1Region,
                Nivel2Provincia = request.Nivel2Provincia,
                Nivel3Distrito = request.Nivel3Distrito,
                Referencia = request.Referencia,
                Latitud = request.Latitud,
                Longitud = request.Longitud
            };

            await _repository.InsertarAsync(entidad);
            return _mapper.Map<UbicacionSistemaDto>(entidad);
        }
    }
}
