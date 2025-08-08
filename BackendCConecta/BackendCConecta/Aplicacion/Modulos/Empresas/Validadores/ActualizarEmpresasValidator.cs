using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Empresas.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Validadores
{
    public class ActualizarEmpresasValidator : AbstractValidator<ActualizarEmpresasCommand>
    {
        public ActualizarEmpresasValidator()
        {
            RuleFor(x => x.IdEmpresa)
                .GreaterThan(0).WithMessage("El identificador es obligatorio.");

            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El nombre es obligatorio.");
        }
    }
}
