using BackendCConecta.Aplicacion.Modulos.Acuerdos.DTOs;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;
using BackendCConecta.Dominio.Entidades.Acuerdos;
using BackendCConecta.Infraestructura.Repositorios.Acuerdos;

namespace BackendCConecta.Infraestructura.Servicios.Acuerdos
{
        public class AcuerdoComercialCommandService : IAcuerdoCommandService
        {
            private readonly AcuerdoRepository _repository;

            public AcuerdoComercialCommandService(AcuerdoRepository repository)
            {
                _repository = repository;
            }

            public async Task<int> CrearAsync(CrearAcuerdoDto dto)
            {
                var entidad = new AcuerdoComercial
                {
                    IdDatosUsuario = dto.IdDatosUsuario,
                    IdTarifaAcuerdo = dto.IdTarifaAcuerdo,
                    FechaInicio = dto.FechaInicio,
                    FechaFin = dto.FechaFin,
                    PublicacionesDisponibles = dto.PublicacionesDisponibles,
                    DiasGracia = dto.DiasGracia,
                    EstadoAcuerdo = dto.EstadoAcuerdo,
                    Observaciones = dto.Observaciones
                };

                return await _repository.CrearAsync(entidad);
            }

            public async Task<bool> ActualizarAsync(int id, ActualizarAcuerdoDto dto)
            {
                var entidad = await _repository.ObtenerPorIdAsync(id);
                if (entidad == null) return false;

                entidad.FechaInicio = dto.FechaInicio;
                entidad.FechaFin = dto.FechaFin;
                entidad.PublicacionesDisponibles = dto.PublicacionesDisponibles;
                entidad.DiasGracia = dto.DiasGracia;
                entidad.EstadoAcuerdo = dto.EstadoAcuerdo;
                entidad.Observaciones = dto.Observaciones;

                return await _repository.ActualizarAsync(entidad);
            }

            public async Task<bool> EliminarAsync(int id)
            {
                return await _repository.EliminarAsync(id);
            }
        }
}