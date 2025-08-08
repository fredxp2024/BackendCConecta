using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Validadores
{
    public class ActualizarPublicacionesValidator : AbstractValidator<ActualizarPublicacionesCommand>
    {
        public ActualizarPublicacionesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
            RuleFor(x => x.Titulo).NotEmpty().WithMessage("El titulo es obligatorio.");
            RuleFor(x => x.Contenido).NotEmpty().WithMessage("El contenido es obligatorio.");
        }
    }
}
