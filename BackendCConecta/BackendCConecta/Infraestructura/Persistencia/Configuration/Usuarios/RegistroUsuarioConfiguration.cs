using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BackendCConecta.Dominio.Entidades.Usuarios;

namespace BackendCConecta.Infraestructura.Persistencia.Configuration.Usuarios;

public class RegistroUsuarioConfiguration : IEntityTypeConfiguration<RegistroUsuario>
{
    public void Configure(EntityTypeBuilder<RegistroUsuario> builder)
    {
        builder.ToTable("RegistroUsuarios");

        builder.HasKey(x => x.IdRegistroUsuario);

        builder.Property(x => x.CorreoElectronico)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(x => x.PasswordHash)
               .IsRequired()
               .HasMaxLength(255);
    }
}
