using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Intereses.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Validadores
{
    public class ActualizarInteresesValidator : AbstractValidator<ActualizarInteresesCommand>
    {
        public ActualizarInteresesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio.");
        }
    }
}
