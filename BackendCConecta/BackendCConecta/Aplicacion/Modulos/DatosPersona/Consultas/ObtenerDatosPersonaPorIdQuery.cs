using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Consultas;

public class ObtenerDatosPersonaPorIdQuery : IRequest<DatosPersonaDto?>
{
    public int IdDatosUsuario { get; set; }

    public ObtenerDatosPersonaPorIdQuery(int idDatosUsuario)
    {
        IdDatosUsuario = idDatosUsuario;
    }
}
