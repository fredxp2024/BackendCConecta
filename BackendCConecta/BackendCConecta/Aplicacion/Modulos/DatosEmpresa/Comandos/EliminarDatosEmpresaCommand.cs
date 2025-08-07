using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Comandos;

public class EliminarDatosEmpresaCommand : IRequest
{
    public int IdDatosUsuario { get; set; }

    public EliminarDatosEmpresaCommand(int idDatosUsuario)
    {
        IdDatosUsuario = idDatosUsuario;
    }
}
