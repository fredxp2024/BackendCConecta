using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.Empresas;

namespace BackendCConecta.Infraestructura.Persistencia.Configuration.Usuarios
{


    public class DatosEmpresaConfiguration : IEntityTypeConfiguration<DatosEmpresa>
    {
        public void Configure(EntityTypeBuilder<DatosEmpresa> builder)
        {
            builder.ToTable("DatosEmpresa");

            builder.HasKey(e => e.IdDatosUsuario);

            builder.HasOne(e => e.IdDatosUsuarioNavigation)
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
