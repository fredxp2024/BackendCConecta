using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BackendCConecta.Dominio.Entidades.Personas;

namespace BackendCConecta.Infraestructura.Persistencia.Configuraciones.Usuarios;

public class DatosPersonaConfiguration : IEntityTypeConfiguration<DatosPersona>
{
    public void Configure(EntityTypeBuilder<DatosPersona> builder)
    {
        builder.ToTable("DatosPersona");

        builder.HasKey(e => e.IdDatosUsuario);

        builder.Property(e => e.Nombres)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(e => e.ApellidoPaterno)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(e => e.ApellidoMaterno)
               .HasMaxLength(100);

        builder.Property(e => e.Dni)
               .HasMaxLength(20);

        builder.HasOne(e => e.IdDatosUsuarioNavigation)
               .WithOne()
               .HasForeignKey<DatosPersona>(e => e.IdDatosUsuario)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
