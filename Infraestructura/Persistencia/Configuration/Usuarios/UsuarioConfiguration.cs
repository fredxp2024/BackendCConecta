using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BackendCConecta.Dominio.Entidades.UsuariosAll;
using BackendCConecta.Dominio.Entidades.Usuario;

namespace BackendCConecta.Infraestructura.Persistencia.Configuration.Usuarios
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(u => u.IdUsuario);

            builder.Property(u => u.CorreoElectronico)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(u => u.PasswordHash)
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(u => u.MetodoAutenticacion)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(u => u.TipoAcceso)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(u => u.Estado)
                   .HasMaxLength(20)
                   .HasDefaultValue("activo");

            builder.Property(u => u.FechaRegistro)
                   .HasDefaultValueSql("GETDATE()");

            builder.HasOne(u => u.DatosUsuario)
                   .WithOne(d => d.Usuario)
                   .HasForeignKey<DatosUsuario>(d => d.IdDatosUsuario)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
