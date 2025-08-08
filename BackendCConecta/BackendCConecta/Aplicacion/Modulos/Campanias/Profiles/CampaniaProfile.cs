using AutoMapper;
using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;
using BackendCConecta.Aplicacion.Modulos.Campanias.Comandos;
using BackendCConecta.Dominio.Entidades.Campanias;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Profiles;

public class CampaniaProfile : Profile
{
    public CampaniaProfile()
    {
        CreateMap<CrearCampaniaCommand, CampaniaDTO>();
        CreateMap<CampaniaDTO, Campania>()
            .ForMember(dest => dest.IdCampania, opt => opt.Ignore())
            .ForMember(dest => dest.FechaRegistro, opt => opt.Ignore());
        CreateMap<Campania, CampaniaDTO>();
    }
}
