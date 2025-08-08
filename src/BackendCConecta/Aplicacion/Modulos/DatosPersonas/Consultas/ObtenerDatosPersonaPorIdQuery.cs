using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Consultas;

public class ObtenerDatosPersonaPorIdQuery : IRequest<DatosPersonaDto?>
{
    public int IdDatosUsuario { get; set; }

    public ObtenerDatosPersonaPorIdQuery(int idDatosUsuario)
    {
        IdDatosUsuario = idDatosUsuario;
    }
}
