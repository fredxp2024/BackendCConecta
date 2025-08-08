namespace BackendCConecta.Dominio.Entidades.Usuarios;

/// <summary>
/// Métodos disponibles para autenticar usuarios.
/// </summary>
public enum MetodoAutenticacion
{
    /// <summary>Autenticación tradicional mediante correo y contraseña.</summary>
    Local,

    /// <summary>Autenticación a través de Google.</summary>
    Google,

    /// <summary>Autenticación a través de Facebook.</summary>
    Facebook
}

