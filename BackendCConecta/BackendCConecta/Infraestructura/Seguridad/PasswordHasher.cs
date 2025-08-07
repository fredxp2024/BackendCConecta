using BackendCConecta.Aplicacion.InterfacesGenerales;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace BackendCConecta.Infraestructura.Seguridad
{
    /// <summary>
    /// Implementación de <see cref="IPasswordHasher"/> basada en PBKDF2.
    /// El formato de almacenamiento es "iteraciones.prf.salt.hash".
    /// Para compatibilidad, también se aceptan valores antiguos con el
    /// esquema "salt.hash" que asumen HMACSHA256 y 10&nbsp;000 iteraciones.
    /// </summary>
    public class PasswordHasher : IPasswordHasher
    {
        private const KeyDerivationPrf Prf = KeyDerivationPrf.HMACSHA256;
        private const int IterationCount = 100000; // Recomendado >=100000
        private const int LegacyIterationCount = 10000;
        private const int SaltSize = 128 / 8;
        private const int NumBytesRequested = 256 / 8;

        public string HashearPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
            byte[] hash = KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: Prf,
                iterationCount: IterationCount,
                numBytesRequested: NumBytesRequested);

            return $"{IterationCount}.{Prf}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        public bool VerificarPassword(string passwordPlano, string hash)
        {
            var partes = hash.Split('.');
            KeyDerivationPrf prf;
            int iterations;
            byte[] salt;
            byte[] hashAlmacenado;

            if (partes.Length == 2)
            {
                // Formato antiguo: salt.hash
                prf = Prf;
                iterations = LegacyIterationCount;
                salt = Convert.FromBase64String(partes[0]);
                hashAlmacenado = Convert.FromBase64String(partes[1]);
            }
            else if (partes.Length == 4)
            {
                // Formato nuevo: iteraciones.prf.salt.hash
                if (!int.TryParse(partes[0], out iterations)) return false;
                if (!Enum.TryParse(partes[1], out prf)) return false;
                salt = Convert.FromBase64String(partes[2]);
                hashAlmacenado = Convert.FromBase64String(partes[3]);
            }
            else
            {
                return false;
            }

            byte[] hashComparar = KeyDerivation.Pbkdf2(
                password: passwordPlano,
                salt: salt,
                prf: prf,
                iterationCount: iterations,
                numBytesRequested: NumBytesRequested);

            return CryptographicOperations.FixedTimeEquals(hashAlmacenado, hashComparar);
        }
    }
}

