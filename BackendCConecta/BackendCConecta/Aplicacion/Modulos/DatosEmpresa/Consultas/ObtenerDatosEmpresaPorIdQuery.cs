using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Consultas;

public class ObtenerDatosEmpresaPorIdQuery : IRequest<DatosEmpresaDto?>
{
    public int IdDatosUsuario { get; set; }

    public ObtenerDatosEmpresaPorIdQuery(int idDatosUsuario)
    {
        IdDatosUsuario = idDatosUsuario;
    }
}
