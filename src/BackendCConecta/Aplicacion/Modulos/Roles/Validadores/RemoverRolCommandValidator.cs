using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Roles.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Roles.Validadores
{
    public class RemoverRolCommandValidator : AbstractValidator<RemoverRolCommand>
    {
        public RemoverRolCommandValidator()
        {
            RuleFor(x => x.IdDatosUsuario)
                .GreaterThan(0).WithMessage("El usuario es obligatorio.");

            RuleFor(x => x.IdRol)
                .GreaterThan(0).WithMessage("El rol es obligatorio.");
        }
    }
}

