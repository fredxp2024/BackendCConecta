using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.UbicacionSistema;

namespace BackendCConecta.Infraestructura.Persistencia.Configuration.Ubication
{
    public class LugaresReferenciaConfiguration : IEntityTypeConfiguration<LugaresReferencia>
    {
        public void Configure(EntityTypeBuilder<LugaresReferencia> builder)
        {
            builder.ToTable("LugaresReferencia");

            builder.HasKey(e => e.IdLugar);
            builder.Property(e => e.NombreLugar).IsRequired().HasMaxLength(150);
            builder.Property(e => e.Descripcion).HasColumnType("TEXT");
            builder.Property(e => e.ReferenciaMapa).HasColumnType("TEXT");
            builder.Property(e => e.VisibleEnPortal).HasDefaultValue(true);

            builder.HasOne(e => e.Ubicaciones)
                .WithMany(u => u.LugaresReferencia)
                .HasForeignKey(e => e.IdUbicacion);

        }

    }
}


