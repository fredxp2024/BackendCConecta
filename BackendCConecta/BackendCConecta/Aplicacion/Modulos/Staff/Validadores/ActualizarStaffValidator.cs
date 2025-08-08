using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Staff.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Staff.Validadores
{
    public class ActualizarStaffValidator : AbstractValidator<ActualizarStaffCommand>
    {
        public ActualizarStaffValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
