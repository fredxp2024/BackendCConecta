using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Aplicacion;
using BackendCConecta.Dominio.Entidades.Eventos;

namespace BackendCConecta.Infraestructura.Persistencia.Configuraciones.Publicaciones
{
    public class EventoConfiguration : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.ToTable("Eventos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TipoEvento).HasMaxLength(100).IsRequired();
            builder.Property(x => x.FechaInicio).IsRequired();
            builder.Property(x => x.FechaFin).IsRequired();
            builder.Property(x => x.Lugar);
            builder.Property(x => x.FechaRegistro).HasDefaultValueSql("GETDATE()");

            builder.HasOne(x => x.Publicacion)
                   .WithOne()
                   .HasForeignKey<Evento>(x => x.IdPublicacion)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
