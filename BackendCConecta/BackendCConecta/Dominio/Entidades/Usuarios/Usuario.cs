using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BackendCConecta.Dominio.Entidades.Representantes;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;

namespace BackendCConecta.Dominio.Entidades.Usuarios;

/// <summary>
/// Representa a un usuario dentro del sistema.
/// </summary>
public partial class Usuario
{
    /// <summary>
    /// Identificador único del usuario.
    /// </summary>
    public int IdUsuario { get; set; }

    /// <summary>
    /// Nombre completo del usuario.
    /// </summary>
    [Required]
    [MaxLength(150)]
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Correo electrónico utilizado para autenticación y notificaciones.
    /// </summary>
    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string CorreoElectronico { get; set; } = null!;

    /// <summary>
    /// Hash de la contraseña del usuario.
    /// </summary>
    [Required]
    [MaxLength(255)]
    public string PasswordHash { get; set; } = null!;

    /// <summary>
    /// Método empleado para la autenticación del usuario.
    /// </summary>
    [Required]
    public MetodoAutenticacion MetodoAutenticacion { get; set; } = MetodoAutenticacion.Local;

    /// <summary>
    /// Nivel de acceso que posee el usuario dentro del sistema.
    /// </summary>
    [Required]
    public TipoAcceso TipoAcceso { get; set; } = TipoAcceso.Usuario;

    /// <summary>
    /// Fecha en la que el usuario fue registrado.
    /// </summary>
    public DateTime? FechaRegistro { get; set; }

    /// <summary>
    /// Estado actual de la cuenta del usuario.
    /// </summary>
    public EstadoUsuario Estado { get; set; } = EstadoUsuario.Activo;

    /// <summary>
    /// Información adicional del usuario.
    /// </summary>
    public virtual DatosUsuario? DatosUsuario { get; set; }

    /// <summary>
    /// Colección de representantes a los que el usuario ha dado "me gusta".
    /// </summary>
    public virtual ICollection<MeGustaRepresentante> MeGustaRepresentantes { get; set; } = new List<MeGustaRepresentante>();
}

