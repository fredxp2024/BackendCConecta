using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;
using BackendCConecta.Dominio.Entidades.Personas;
using BackendCConecta.Dominio.Entidades.Empresas;

namespace BackendCConecta.Infraestructura.Persistencia.Configuraciones.Usuarios
{
    public class DatosUsuarioConfiguration : IEntityTypeConfiguration<DatosUsuario>
    {
        public void Configure(EntityTypeBuilder<DatosUsuario> builder)
        {
            builder.ToTable("DatosUsuario");

            builder.HasKey(d => d.IdDatosUsuario);

            builder.Property(d => d.TipoUsuario)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(d => d.EstadoColaborador)
                   .HasMaxLength(50)
                   .HasDefaultValue("ninguno");

            builder.Property(d => d.EstadoGeneral)
                   .HasMaxLength(20)
                   .HasDefaultValue("activo");

            builder.Property(d => d.FechaRegistro)
                   .HasDefaultValueSql("GETDATE()");

            // Relaciones 1:1
            builder.HasOne(d => d.Persona)
                   .WithOne(p => p.DatosUsuario)
                   .HasForeignKey<DatosPersona>(p => p.IdDatosUsuario)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(d => d.Empresa)
                   .WithOne(e => e.DatosUsuario)
                   .HasForeignKey<DatosEmpresa>(e => e.IdDatosUsuario)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}