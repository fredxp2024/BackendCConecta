using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Empresas.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Validadores
{
    public class CrearEmpresasValidator : AbstractValidator<CrearEmpresasCommand>
    {
        public CrearEmpresasValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El nombre es obligatorio.");
        }
    }
}
