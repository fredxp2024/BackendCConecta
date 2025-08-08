using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Validadores
{
    public class ActualizarColaboradoresValidator : AbstractValidator<ActualizarColaboradoresCommand>
    {
        public ActualizarColaboradoresValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio.");
        }
    }
}
