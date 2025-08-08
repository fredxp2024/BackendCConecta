using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Validadores
{
    public class EliminarPaquetesValidator : AbstractValidator<EliminarPaquetesCommand>
    {
        public EliminarPaquetesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El ID debe ser mayor que cero.");
        }
    }
}
