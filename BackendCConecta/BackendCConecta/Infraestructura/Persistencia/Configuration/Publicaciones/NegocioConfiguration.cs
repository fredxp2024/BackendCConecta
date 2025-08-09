using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.Negocios;

namespace BackendCConecta.Infraestructura.Persistencia.Configuration.Publicaciones;

public class NegocioConfiguration : IEntityTypeConfiguration<Negocio>
{
    public void Configure(EntityTypeBuilder<Negocio> builder)
    {
        builder.ToTable("Negocios");

        builder.HasKey(x => x.IdNegocio);

        builder.Property(x => x.NombreNegocio).HasMaxLength(150).IsRequired();
        builder.Property(x => x.TipoNegocio).HasMaxLength(100);
        builder.Property(x => x.DescripcionServicio);
        builder.Property(x => x.HorarioAtencion).HasMaxLength(100);
        builder.Property(x => x.PaginaWeb);
        builder.Property(x => x.DeliveryDisponible).HasDefaultValue(false);
        builder.Property(x => x.FormatoVenta).HasMaxLength(100);
        builder.Property(x => x.FechaRegistro).HasDefaultValueSql("GETDATE()");

        builder.HasOne(x => x.IdPublicacionNavigation)
               .WithOne(p => p.Negocio)
               .HasForeignKey<Negocio>(x => x.IdPublicacion)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
