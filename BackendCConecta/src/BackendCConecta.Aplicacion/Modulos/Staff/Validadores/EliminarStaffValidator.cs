using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Staff.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Staff.Validadores
{
    public class EliminarStaffValidator : AbstractValidator<EliminarStaffCommand>
    {
        public EliminarStaffValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
        }
    }
}
