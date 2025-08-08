using System.Security.Cryptography;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Collections.Generic;

namespace BackendCConecta.Infraestructura.Helpers
{
    /// <summary>
    /// Conjunto de utilidades relacionadas con seguridad y tokens JWT.
    /// </summary>
    public static class SecurityUtils
    {
        /// <summary>
        /// Genera un token JWT firmado con la clave proporcionada.
        /// </summary>
        /// <param name="claims">Claims que se incluirán en el token.</param>
        /// <param name="key">Clave simétrica para firmar el token.</param>
        /// <param name="issuer">Issuer del token.</param>
        /// <param name="audience">Audiencia del token.</param>
        /// <param name="expirationMinutes">Tiempo de expiración en minutos.</param>
        /// <returns>Cadena JWT generada.</returns>
        public static string GenerateJwtToken(IEnumerable<Claim> claims, string key, string issuer, string audience, int expirationMinutes)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(expirationMinutes),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        /// <summary>
        /// Valida un token JWT utilizando la clave y parámetros proporcionados.
        /// </summary>
        /// <param name="token">Token JWT a validar.</param>
        /// <param name="key">Clave simétrica usada para validar la firma.</param>
        /// <param name="issuer">Issuer esperado.</param>
        /// <param name="audience">Audiencia esperada.</param>
        /// <returns>ClaimsPrincipal si el token es válido; de lo contrario, null.</returns>
        public static ClaimsPrincipal? ValidateJwtToken(string token, string key, string issuer, string audience)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var parameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateIssuerSigningKey = true,
                ValidateLifetime = true,
                ValidIssuer = issuer,
                ValidAudience = audience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
                ClockSkew = TimeSpan.Zero
            };

            try
            {
                var principal = tokenHandler.ValidateToken(token, parameters, out _);
                return principal;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Genera un token de actualización aleatorio y seguro.
        /// </summary>
        /// <param name="size">Longitud en bytes del token.</param>
        /// <returns>Token en formato Base64.</returns>
        public static string GenerateRefreshToken(int size = 32)
        {
            var randomNumber = new byte[size];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
    }
}