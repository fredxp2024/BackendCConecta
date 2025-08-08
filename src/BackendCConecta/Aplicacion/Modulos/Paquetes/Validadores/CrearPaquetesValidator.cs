using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Validadores
{
    public class CrearPaquetesValidator : AbstractValidator<CrearPaquetesCommand>
    {
        public CrearPaquetesValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
