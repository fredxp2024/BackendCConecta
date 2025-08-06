using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.Usuarios;

namespace BackendCConecta.Infraestructura.Persistencia.Configuraciones.Usuarios
{


    public class DatosEmpresaConfiguration : IEntityTypeConfiguration<DatosEmpresa>
    {
        public void Configure(EntityTypeBuilder<DatosEmpresa> builder)
        {
            builder.ToTable("DatosEmpresa");

            builder.HasKey(e => e.IdDatosUsuario);

            builder.HasOne(e => e.DatosUsuario)
                   .WithOne(d => d.DatosEmpresa)
                   .HasForeignKey<DatosEmpresa>(e => e.IdDatosUsuario);

            builder.Property(e => e.RazonSocial)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(e => e.Ruc)
                   .HasMaxLength(15);

            builder.Property(e => e.PaginaWeb)
                   .HasColumnType("TEXT");
        }
    }
}
