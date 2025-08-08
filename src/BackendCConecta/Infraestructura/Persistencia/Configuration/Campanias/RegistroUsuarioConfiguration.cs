using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.Roles;

namespace BackendCConecta.Infraestructura.Persistencia.Configuraciones.Campanias
{
    public class RegistroUsuarioConfiguration : IEntityTypeConfiguration<UsuarioRol>
    {
        public void Configure(EntityTypeBuilder<UsuarioRol> builder)
        {
            builder.ToTable("UsuariosRoles");

            builder.HasKey(ur => ur.IdUsuarioRol);

            builder.HasOne(ur => ur.IdDatosUsuarioNavigation)
                   .WithMany(d => d.UsuariosRoles)
                   .HasForeignKey(ur => ur.IdDatosUsuario);

            builder.HasOne(ur => ur.IdRolNavigation)
                   .WithMany(r => r.UsuariosRoles)
                   .HasForeignKey(ur => ur.IdRol);

            builder.Property(ur => ur.FechaAsignacion)
                   .HasDefaultValueSql("GETDATE()");
        }
    }
}