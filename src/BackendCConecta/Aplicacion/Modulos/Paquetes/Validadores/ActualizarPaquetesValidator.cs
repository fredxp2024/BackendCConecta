using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Validadores
{
    public class ActualizarPaquetesValidator : AbstractValidator<ActualizarPaquetesCommand>
    {
        public ActualizarPaquetesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El ID debe ser mayor que cero.");
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
