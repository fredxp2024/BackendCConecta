using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Validadores
{
    public class CrearColaboradoresValidator : AbstractValidator<CrearColaboradoresCommand>
    {
        public CrearColaboradoresValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
