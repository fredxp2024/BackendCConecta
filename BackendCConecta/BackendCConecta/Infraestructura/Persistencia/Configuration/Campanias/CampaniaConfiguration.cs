using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BackendCConecta.Dominio.Entidades.Campanias;

namespace BackendCConecta.Infraestructura.Persistencia.Configuraciones.Campanias
{
    public class CampaniaConfiguration : IEntityTypeConfiguration<Campania>
    {
        public void Configure(EntityTypeBuilder<Campania> builder)
        {
            builder.ToTable("Campania");

            builder.HasKey(c => c.IdCampania);

            builder.Property(c => c.Titulo)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(c => c.TipoCampania)
                   .HasDefaultValue("promocional")
                   .HasMaxLength(50);

            builder.Property(c => c.Estado)
                   .HasDefaultValue("activo")
                   .HasMaxLength(20);

            builder.Property(c => c.FechaRegistro)
                   .HasDefaultValueSql("GETDATE()");

            builder.HasOne(c => c.IdUbicacionNavigation)
                   .WithMany()
                   .HasForeignKey(c => c.IdUbicacion)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.IdStaffNavigation)
                   .WithMany()
                   .HasForeignKey(c => c.IdStaff);
        }
    }
}
