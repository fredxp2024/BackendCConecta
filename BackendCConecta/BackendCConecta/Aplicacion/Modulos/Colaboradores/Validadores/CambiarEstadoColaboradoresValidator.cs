using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Validadores
{
    public class CambiarEstadoColaboradoresValidator : AbstractValidator<CambiarEstadoColaboradoresCommand>
    {
        public CambiarEstadoColaboradoresValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
