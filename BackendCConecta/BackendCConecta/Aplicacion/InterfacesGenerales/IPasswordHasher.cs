namespace BackendCConecta.Aplicacion.InterfacesGenerales
{
    /// <summary>
    /// Define operaciones para generar y verificar hashes de contraseñas.
    /// Los hashes se almacenan como <c>iteraciones.prf.salt.hash</c> en Base64.
    /// El formato legacy <c>salt.hash</c> continúa siendo soportado.
    /// </summary>
    public interface IPasswordHasher
    {
        string HashearPassword(string password);
        bool VerificarPassword(string passwordPlano, string hash);
    }
}
