using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Validadores
{
    public class EliminarColaboradoresValidator : AbstractValidator<EliminarColaboradoresCommand>
    {
        public EliminarColaboradoresValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
        }
    }
}
