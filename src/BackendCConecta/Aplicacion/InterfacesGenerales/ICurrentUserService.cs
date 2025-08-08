namespace BackendCConecta.Aplicacion.InterfacesGenerales;

/// <summary>
/// Servicio para obtener información del usuario autenticado.
/// </summary>
public interface ICurrentUserService
{
    /// <summary>
    /// Determina si el usuario actual posee el rol especificado.
    /// </summary>
    /// <param name="role">Nombre del rol a verificar.</param>
    /// <returns><c>true</c> si el usuario tiene el rol; de lo contrario, <c>false</c>.</returns>
    bool HasRole(string role);
}

