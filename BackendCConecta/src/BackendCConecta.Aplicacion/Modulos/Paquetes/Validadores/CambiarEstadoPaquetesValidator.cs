using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Validadores
{
    public class CambiarEstadoPaquetesValidator : AbstractValidator<CambiarEstadoPaquetesCommand>
    {
        public CambiarEstadoPaquetesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El ID debe ser mayor que cero.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
