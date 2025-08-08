using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Auth.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Auth.Validadores;

public class RefreshTokenCommandValidator : AbstractValidator<RefreshTokenCommand>
{
    public RefreshTokenCommandValidator()
    {
        RuleFor(x => x.Token)
            .NotEmpty().WithMessage("El token es obligatorio.");

        RuleFor(x => x.RefreshToken)
            .NotEmpty().WithMessage("El refresh token es obligatorio.");
    }
}
