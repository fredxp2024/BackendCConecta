using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Roles.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Roles.Validadores
{
    public class AsignarRolCommandValidator : AbstractValidator<AsignarRolCommand>
    {
        public AsignarRolCommandValidator()
        {
            RuleFor(x => x.IdDatosUsuario)
                .GreaterThan(0).WithMessage("El usuario es obligatorio.");

            RuleFor(x => x.IdRol)
                .GreaterThan(0).WithMessage("El rol es obligatorio.");
        }
    }
}

