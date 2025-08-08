using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Empresas.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Validadores
{
    public class EliminarEmpresasValidator : AbstractValidator<EliminarEmpresasCommand>
    {
        public EliminarEmpresasValidator()
        {
            RuleFor(x => x.IdEmpresa)
                .GreaterThan(0).WithMessage("El identificador es obligatorio.");
        }
    }
}
