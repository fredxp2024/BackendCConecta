using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Historiales.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Validadores
{
    public class CambiarEstadoHistorialesValidator : AbstractValidator<CambiarEstadoHistorialesCommand>
    {
        public CambiarEstadoHistorialesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El identificador es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
