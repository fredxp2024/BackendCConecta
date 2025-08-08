using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Intereses.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Validadores
{
    public class CrearInteresesValidator : AbstractValidator<CrearInteresesCommand>
    {
        public CrearInteresesValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
