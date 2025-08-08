using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Staff.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Staff.Validadores
{
    public class CrearStaffValidator : AbstractValidator<CrearStaffCommand>
    {
        public CrearStaffValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
