using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BackendCConecta.Dominio.Entidades;
using BackendCConecta.Dominio.Entidades.Usuarios;

namespace BackendCConecta.Infraestructura.Persistencia.Configuration.Usuarios
{
    public class RegistroUsuarioConfiguration : IEntityTypeConfiguration<RegistroUsuarioConfiguration>
    {
        public void Configure(EntityTypeBuilder<RegistroUsuarioConfiguration> builder)
        {
            builder.ToTable("RegistroUsuarios");

            builder.HasKey(x => x.id_registrousuario);

            builder.Property(x => x.correo_electronico)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.password_hash)
                   .IsRequired()
                   .HasMaxLength(255);
        }
    }
}
