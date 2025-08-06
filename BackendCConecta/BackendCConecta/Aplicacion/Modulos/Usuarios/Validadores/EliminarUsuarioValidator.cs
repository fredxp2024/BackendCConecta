using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Validadores
{
    public class EliminarUsuarioValidator : AbstractValidator<EliminarUsuarioCommand>
    {
        public EliminarUsuarioValidator()
        {
            RuleFor(x => x.IdUsuario)
                .GreaterThan(0).WithMessage("Debe proporcionar un ID de usuario válido para eliminar.");
        }
    }
}
