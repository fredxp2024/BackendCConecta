using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Historiales.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Validadores
{
    public class ActualizarHistorialesValidator : AbstractValidator<ActualizarHistorialesCommand>
    {
        public ActualizarHistorialesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El identificador es obligatorio.");
            RuleFor(x => x.Descripcion).NotEmpty().WithMessage("La descripción es obligatoria.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
