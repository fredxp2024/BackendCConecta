using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.Avisos;
 
namespace BackendCConecta.Infraestructura.Persistencia.Configuration.Publicaciones
{
    public class AvisoConfiguration : IEntityTypeConfiguration<Aviso>
    {
        public void Configure(EntityTypeBuilder<Aviso> builder)
        {
            builder.ToTable("Avisos");

            builder.HasKey(x => x.IdAviso);

            builder.Property(x => x.TipoAviso).HasMaxLength(50);
            builder.Property(x => x.Modalidad).HasMaxLength(50);
            builder.Property(x => x.Condiciones);
            builder.Property(x => x.EsNegociable).HasDefaultValue(false);
            builder.Property(x => x.FormaPago).HasMaxLength(100);
            builder.Property(x => x.FechaDisponible);
            builder.Property(x => x.FechaRegistro).HasDefaultValueSql("GETDATE()");

            builder.HasOne(x => x.IdPublicacionNavigation)
                   .WithOne(p => p.Aviso)
                   .HasForeignKey<Aviso>(x => x.IdPublicacion)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
