using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BackendCConecta.Aplicacion.InterfacesGenerales;

namespace BackendCConecta.Infraestructura.Seguridad
{
    public class JwtSettings
    {
        public string Key { get; set; } = default!;
        public string Issuer { get; set; } = default!;
        public string Audience { get; set; } = default!;
        public int ExpirationHours { get; set; }
    }

    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtSettings _settings;

        public JwtTokenGenerator(IOptions<JwtSettings> options)
        {
            _settings = options.Value;
        }

        public string GenerarToken(int idUsuario, string correo, string tipoAcceso)
        {
            if (idUsuario <= 0) throw new ArgumentException("Id de usuario inválido.", nameof(idUsuario));
            if (string.IsNullOrWhiteSpace(correo)) throw new ArgumentNullException(nameof(correo));
            if (string.IsNullOrWhiteSpace(tipoAcceso)) throw new ArgumentNullException(nameof(tipoAcceso));

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, idUsuario.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, correo),
                new Claim(ClaimTypes.Role, tipoAcceso),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var keyBytes = Encoding.UTF8.GetBytes(_settings.Key);
            if (keyBytes.Length < 32)
                throw new ArgumentException("La clave JWT debe tener al menos 32 bytes.", nameof(_settings.Key));

            var key = new SymmetricSecurityKey(keyBytes);
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _settings.Issuer,
                audience: _settings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(_settings.ExpirationHours),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
