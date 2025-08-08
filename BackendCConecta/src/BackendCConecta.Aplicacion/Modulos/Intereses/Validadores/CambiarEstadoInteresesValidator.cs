using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Intereses.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Validadores
{
    public class CambiarEstadoInteresesValidator : AbstractValidator<CambiarEstadoInteresesCommand>
    {
        public CambiarEstadoInteresesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
