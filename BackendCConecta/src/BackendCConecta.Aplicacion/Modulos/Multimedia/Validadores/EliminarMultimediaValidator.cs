using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Validadores
{
    public class EliminarMultimediaValidator : AbstractValidator<EliminarMultimediaCommand>
    {
        public EliminarMultimediaValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
        }
    }
}
