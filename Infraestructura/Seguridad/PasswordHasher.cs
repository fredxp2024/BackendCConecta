using BackendCConecta.Aplicacion.InterfacesGenerales;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace BackendCConecta.Infraestructura.Seguridad
{
    public class PasswordHasher : IPasswordHasher
    {
        public string HashearPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);

            string hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return $"{Convert.ToBase64String(salt)}.{hash}";
        }

        public bool VerificarPassword(string passwordPlano, string hash)
        {
            var partes = hash.Split('.');
            if (partes.Length != 2) return false;

            var salt = Convert.FromBase64String(partes[0]);
            var hashComparar = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: passwordPlano,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashComparar == partes[1];
        }
    }
}
