using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Comandos;

public class ActualizarDatosEmpresaCommand : IRequest
{
    public int IdDatosUsuario { get; set; }
    public ActualizarDatosEmpresaDto Datos { get; set; }

    public ActualizarDatosEmpresaCommand(int idDatosUsuario, ActualizarDatosEmpresaDto datos)
    {
        IdDatosUsuario = idDatosUsuario;
        Datos = datos;
    }
}
