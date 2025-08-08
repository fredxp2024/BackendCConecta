using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Historiales.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Validadores
{
    public class CrearHistorialesValidator : AbstractValidator<CrearHistorialesCommand>
    {
        public CrearHistorialesValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty().WithMessage("La descripción es obligatoria.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
