using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Empresas.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Validadores
{
    public class CambiarEstadoEmpresasValidator : AbstractValidator<CambiarEstadoEmpresasCommand>
    {
        public CambiarEstadoEmpresasValidator()
        {
            RuleFor(x => x.IdEmpresa)
                .GreaterThan(0).WithMessage("El identificador es obligatorio.");

            RuleFor(x => x.Estado)
                .NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
