using AutoMapper;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.DTOs;
using BackendCConecta.Dominio.Entidades.Acuerdos;
using System;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Profiles;

public class AcuerdoProfile : Profile
{
    public AcuerdoProfile()
    {
        CreateMap<AcuerdosComercial, AcuerdoDto>()
            .ForMember(d => d.Id, opt => opt.MapFrom(s => s.IdAcuerdo))
            .ForMember(d => d.FechaInicio, opt => opt.MapFrom(s => s.FechaInicio.ToDateTime(TimeOnly.MinValue)))
            .ForMember(d => d.FechaFin, opt => opt.MapFrom(s => s.FechaFin.ToDateTime(TimeOnly.MinValue)))
            .ForMember(d => d.DiasGracia, opt => opt.MapFrom(s => s.DiasGracia ?? 0))
            .ForMember(d => d.EstadoAcuerdo, opt => opt.MapFrom(s => s.EstadoAcuerdo ?? string.Empty))
            .ForMember(d => d.Observaciones, opt => opt.MapFrom(s => s.Observaciones ?? string.Empty))
            .ForMember(d => d.FechaRegistro, opt => opt.MapFrom(s => s.FechaRegistro ?? default));

        CreateMap<CrearAcuerdoDto, AcuerdosComercial>()
            .ForMember(d => d.IdAcuerdo, opt => opt.Ignore())
            .ForMember(d => d.FechaInicio, opt => opt.MapFrom(s => DateOnly.FromDateTime(s.FechaInicio)))
            .ForMember(d => d.FechaFin, opt => opt.MapFrom(s => DateOnly.FromDateTime(s.FechaFin)))
            .ForMember(d => d.FechaRegistro, opt => opt.Ignore());

        CreateMap<ActualizarAcuerdoDto, AcuerdosComercial>()
            .ForMember(d => d.IdAcuerdo, opt => opt.MapFrom(s => s.Id))
            .ForMember(d => d.FechaInicio, opt => opt.MapFrom(s => DateOnly.FromDateTime(s.FechaInicio)))
            .ForMember(d => d.FechaFin, opt => opt.MapFrom(s => DateOnly.FromDateTime(s.FechaFin)))
            .ForMember(d => d.FechaRegistro, opt => opt.Ignore());
    }
}
