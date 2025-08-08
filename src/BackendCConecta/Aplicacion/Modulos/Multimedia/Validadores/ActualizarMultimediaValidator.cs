using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Validadores
{
    public class ActualizarMultimediaValidator : AbstractValidator<ActualizarMultimediaCommand>
    {
        public ActualizarMultimediaValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
            RuleFor(x => x.Url).NotEmpty().WithMessage("La url es obligatoria.");
        }
    }
}
