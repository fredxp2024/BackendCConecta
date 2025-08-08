using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Consultas;

public class ObtenerDatosEmpresaPorIdQuery : IRequest<DatosEmpresaDto?>
{
    public int IdDatosUsuario { get; set; }

    public ObtenerDatosEmpresaPorIdQuery(int idDatosUsuario)
    {
        IdDatosUsuario = idDatosUsuario;
    }
}
