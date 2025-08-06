using BackendCConecta.Aplicacion.Modulos.Acuerdos.DTOs;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;
using BackendCConecta.Infraestructura.Repositorios.Acuerdos;

namespace BackendCConecta.Infraestructura.Servicios.Acuerdos
{
public class AcuerdoComercialQueryService : IAcuerdoQueryService
{
    private readonly AcuerdoRepository _repository;

    public AcuerdoComercialQueryService(AcuerdoRepository repository)
    {
        _repository = repository;
    }

    public async Task<AcuerdoDto> ObtenerPorIdAsync(int id)
    {
        var entidad = await _repository.ObtenerPorIdAsync(id);
        return new AcuerdoDto
        {
            Id = entidad.Id,
            IdDatosUsuario = entidad.IdDatosUsuario,
            IdTarifaAcuerdo = entidad.IdTarifaAcuerdo,
            FechaInicio = entidad.FechaInicio,
            FechaFin = entidad.FechaFin,
            PublicacionesDisponibles = entidad.PublicacionesDisponibles,
            DiasGracia = entidad.DiasGracia,
            EstadoAcuerdo = entidad.EstadoAcuerdo,
            Observaciones = entidad.Observaciones,
            FechaRegistro = entidad.FechaRegistro
        };
    }

    public async Task<List<AcuerdoDto>> ListarAsync()
    {
        var lista = await _repository.ListarAsync();
        return lista.Select(e => new AcuerdoDto
        {
            Id = e.Id,
            IdDatosUsuario = e.IdDatosUsuario,
            IdTarifaAcuerdo = e.IdTarifaAcuerdo,
            FechaInicio = e.FechaInicio,
            FechaFin = e.FechaFin,
            PublicacionesDisponibles = e.PublicacionesDisponibles,
            DiasGracia = e.DiasGracia,
            EstadoAcuerdo = e.EstadoAcuerdo,
            Observaciones = e.Observaciones,
            FechaRegistro = e.FechaRegistro
        }).ToList();
    }
}
}