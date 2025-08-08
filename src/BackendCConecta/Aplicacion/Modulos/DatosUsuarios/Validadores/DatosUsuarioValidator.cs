using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Validadores;

public class DatosUsuarioValidator : AbstractValidator<ActualizarDatosUsuarioCommand>
{
    public DatosUsuarioValidator()
    {
        RuleFor(x => x.IdDatosUsuario).GreaterThan(0);
        RuleFor(x => x.Celular).MaximumLength(20);
        RuleFor(x => x.Direccion).MaximumLength(255);
        RuleFor(x => x.ImagenPerfil).MaximumLength(255);
        RuleFor(x => x.TipoUsuario).NotEmpty();
        RuleFor(x => x.EstadoColaborador).MaximumLength(100);
        RuleFor(x => x.EstadoGeneral).MaximumLength(100);
    }
}
