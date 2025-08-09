using BackendCConecta.Dominio.Entidades.Usuarios;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackendCConecta.Infraestructura.Persistencia.Configuration.Usuarios;

/// <summary>
/// Configuración de EF Core para la entidad <see cref="Usuario"/>.
/// </summary>
public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuarios");

        builder.HasKey(u => u.IdUsuario);

        builder.Property(u => u.CorreoElectronico)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(u => u.PasswordHash)
               .IsRequired()
               .HasMaxLength(255);

        builder.Property(u => u.MetodoAutenticacion)
               .IsRequired()
               .HasConversion<string>()
               .HasMaxLength(50);

        builder.Property(u => u.TipoAcceso)
               .IsRequired()
               .HasConversion<string>()
               .HasMaxLength(50);

        builder.Property(u => u.Estado)
               .HasConversion<string>()
               .HasMaxLength(20)
               .HasDefaultValue(EstadoUsuario.Activo);

        builder.Property(u => u.Nombre)
               .IsRequired()
               .HasMaxLength(150);

        builder.Property(u => u.FechaRegistro)
               .HasDefaultValueSql("GETDATE()");

        builder.HasOne(u => u.DatosUsuario)
               .WithOne(d => d.IdUsuarioNavigation)
               .HasForeignKey<DatosUsuario>(d => d.IdUsuario)
               .OnDelete(DeleteBehavior.Cascade);
    }
}

