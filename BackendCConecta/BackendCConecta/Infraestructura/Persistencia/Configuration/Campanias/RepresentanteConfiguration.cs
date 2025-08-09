using BackendCConecta.Dominio.Entidades.Representantes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackendCConecta.Infraestructura.Persistencia.Configuraciones.Campanias;

public class RepresentanteConfiguration : IEntityTypeConfiguration<Representante>
{
    public void Configure(EntityTypeBuilder<Representante> builder)
    {
        builder.ToTable("Representantes");

        builder.HasKey(r => r.IdRepresentante);

        builder.Property(r => r.Nombres).IsRequired().HasMaxLength(100);
        builder.Property(r => r.Apellidos).IsRequired().HasMaxLength(100);
        builder.Property(r => r.Profesion).HasMaxLength(100);
        builder.Property(r => r.LugarTrabajo).HasMaxLength(150);
        builder.Property(r => r.TipoCandidato).IsRequired().HasMaxLength(50);

        builder.Property(r => r.VisiblePublicamente)
               .HasDefaultValue(true);

        builder.Property(r => r.FechaRegistro)
               .HasDefaultValueSql("GETDATE()");

        builder.HasOne(r => r.IdPublicacionNavigation)
               .WithOne(p => p.Representante)
               .HasForeignKey<Representante>(r => r.IdPublicacion)
               .OnDelete(DeleteBehavior.Cascade);
    }
}

