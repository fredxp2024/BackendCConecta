using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;

public sealed record EliminarDatosUsuarioCommand(int IdDatosUsuario) : IRequest<bool>;

