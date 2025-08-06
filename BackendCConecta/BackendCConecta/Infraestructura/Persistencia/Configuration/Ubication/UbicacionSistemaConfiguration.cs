using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.UbicacionSistema;

public class UbicacionesSistemaConfiguration : IEntityTypeConfiguration<UbicacionSistema>
{
    public void Configure(EntityTypeBuilder<UbicacionSistema> builder)
    {
        builder.ToTable("UbicacionesSistema");

        builder.HasKey(e => e.IdUbicacion);

        builder.Property(e => e.Pais).HasMaxLength(100);
        builder.Property(e => e.Nivel1Region).HasMaxLength(100);
        builder.Property(e => e.Nivel2Provincia).HasMaxLength(100);
        builder.Property(e => e.Nivel3Distrito).HasMaxLength(100);
        builder.Property(e => e.Referencia).HasColumnType("TEXT");
        builder.Property(e => e.Latitud).HasColumnType("decimal(9,6)");
        builder.Property(e => e.Longitud).HasColumnType("decimal(9,6)");
    }
}
