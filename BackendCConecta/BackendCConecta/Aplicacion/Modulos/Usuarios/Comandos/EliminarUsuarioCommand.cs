using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos;

public sealed record EliminarUsuarioCommand(int IdUsuario) : IRequest<bool>;

