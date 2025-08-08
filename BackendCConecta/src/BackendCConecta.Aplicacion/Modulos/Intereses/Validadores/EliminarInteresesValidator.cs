using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Intereses.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Validadores
{
    public class EliminarInteresesValidator : AbstractValidator<EliminarInteresesCommand>
    {
        public EliminarInteresesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
        }
    }
}
