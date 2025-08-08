using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Historiales.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Validadores
{
    public class EliminarHistorialesValidator : AbstractValidator<EliminarHistorialesCommand>
    {
        public EliminarHistorialesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El identificador es obligatorio.");
        }
    }
}
