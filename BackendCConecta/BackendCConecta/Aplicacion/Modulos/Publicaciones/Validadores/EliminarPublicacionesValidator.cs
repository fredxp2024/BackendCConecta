using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Validadores
{
    public class EliminarPublicacionesValidator : AbstractValidator<EliminarPublicacionesCommand>
    {
        public EliminarPublicacionesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
        }
    }
}
