namespace BackendCConecta.Dominio.Entidades.Usuarios;

/// <summary>
/// Roles o niveles de acceso permitidos para los usuarios.
/// </summary>
public enum TipoAcceso
{
    /// <summary>Acceso básico de usuario estándar.</summary>
    Usuario,

    /// <summary>Acceso para usuarios colaboradores.</summary>
    Colaborador,

    /// <summary>Acceso con privilegios administrativos.</summary>
    Administrador
}

