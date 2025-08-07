using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

// 🧾 Acuerdos
using BackendCConecta.Dominio.Entidades.Acuerdos;

// 📢 Avisos
using BackendCConecta.Dominio.Entidades.Avisos;

// 📆 Campañas
using BackendCConecta.Dominio.Entidades.Campanias;
using BackendCConecta.Dominio.Entidades.CampaniasPromocionales;

// 👥 Colaboradores
using BackendCConecta.Dominio.Entidades.Colaboradores;

// 📇 Contactos
using BackendCConecta.Dominio.Entidades.Contactos;

// 🏢 Empresas y Personas
using BackendCConecta.Dominio.Entidades.Empresas;
using BackendCConecta.Dominio.Entidades.Personas;

// 🎉 Eventos
using BackendCConecta.Dominio.Entidades.Eventos;

// 📅 Fechas importantes
using BackendCConecta.Dominio.Entidades.FechasImportantess;

// 🕓 Historiales
using BackendCConecta.Dominio.Entidades.Historiales;

// ❤️ Intereses
using BackendCConecta.Dominio.Entidades.Intereses;

// 🖼️ Multimedia
using BackendCConecta.Dominio.Entidades.Multimedia;

// 🏪 Negocios
using BackendCConecta.Dominio.Entidades.Negocios;

// 🎁 Paquetes
using BackendCConecta.Dominio.Entidades.Paquetes;

// 📰 Publicaciones
using BackendCConecta.Dominio.Entidades.Publicaciones;

// 🧑‍💼 Representantes
using BackendCConecta.Dominio.Entidades.Representantes;

// 🔐 Roles
using BackendCConecta.Dominio.Entidades.Roles;

// 🧑‍🏫 Staff
using BackendCConecta.Dominio.Entidades.Staff;

// 💳 Transacciones
using BackendCConecta.Dominio.Entidades.Transacciones;

// 🌍 Ubicación del sistema
using BackendCConecta.Dominio.Entidades.UbicacionSistema;

// 👤 Usuarios
using BackendCConecta.Dominio.Entidades.Usuarios;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;


   

namespace BackendCConecta.Infraestructura.Persistencia;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // 🧾 Acuerdos
    public virtual DbSet<AcuerdosComercial> AcuerdosComerciales { get; set; }
    public virtual DbSet<CapturasTransaccionAcuerdo> CapturasTransaccionAcuerdos { get; set; }

    // 📢 Avisos
    public virtual DbSet<Aviso> Avisos { get; set; }

    // 📆 Campañas
    public virtual DbSet<Campania> Campanias { get; set; }
    public virtual DbSet<CampaniasElectoral> CampaniasElectorales { get; set; }
    public virtual DbSet<CampaniasPromocional> CampaniasPromocionales { get; set; }
    public virtual DbSet<GanadoresCampaniaPromocional> GanadoresCampaniaPromocionales { get; set; }
    public virtual DbSet<ParticipantesCampaniaPromocional> ParticipantesCampaniaPromocionales { get; set; }
    public virtual DbSet<PremiosCampaniaPromocional> PremiosCampaniaPromocionales { get; set; }

    // 👥 Colaboradores
    public virtual DbSet<Colaborador> Colaboradores { get; set; }
    public virtual DbSet<ParticipacionColaborador> ParticipacionColaboradores { get; set; }
    public virtual DbSet<PerfilColaboradorExtendido> PerfilColaboradorExtendidos { get; set; }
    public virtual DbSet<PostulacionesColaborador> PostulacionesColaboradores { get; set; }
    public virtual DbSet<ReconocimientosColaborador> ReconocimientosColaboradores { get; set; }

    // 📇 Contactos
    public virtual DbSet<ContactosAdicionalesPublicacion> ContactosAdicionalesPublicaciones { get; set; }

    // 🏢 Empresas y Personas
    public virtual DbSet<DatosEmpresa> DatosEmpresas { get; set; }
    public virtual DbSet<DatosPersona> DatosPersonas { get; set; }

    // 🎉 Eventos
    public virtual DbSet<Evento> Eventos { get; set; }

    // 📅 Fechas importantes
    public virtual DbSet<FechasImportantes> FechasImportantes { get; set; }
    public virtual DbSet<TiposFechaImportantes> TiposFechaImportantes { get; set; }

    // 🕓 Historiales
    public virtual DbSet<HistorialCargosRepresentante> HistorialCargosRepresentantes { get; set; }
    public virtual DbSet<HistorialEstadosPublicacion> HistorialEstadosPublicaciones { get; set; }
    public virtual DbSet<HistorialEstadosTransaccion> HistorialEstadosTransacciones { get; set; }
    public virtual DbSet<HistorialModificacionesAcuerdo> HistorialModificacionesAcuerdos { get; set; }
    public virtual DbSet<HistorialPostulacionesColaborador> HistorialPostulacionesColaboradores { get; set; }
    public virtual DbSet<HistorialPublicacionFecha> HistorialPublicacionFechas { get; set; }

    // ❤️ Intereses
    public virtual DbSet<Interes> Intereses { get; set; }
    public virtual DbSet<InteresesPublicacion> InteresesPublicaciones { get; set; }
    public virtual DbSet<InteresesUsuario> InteresesUsuarios { get; set; }

    // 🖼️ Multimedia
    public virtual DbSet<ArchivosAdjuntosPublicacion> ArchivosAdjuntosPublicaciones { get; set; }
    public virtual DbSet<LinksMultimedia> LinksMultimedias { get; set; }
    public virtual DbSet<MultimediaPublicacion> MultimediaPublicaciones { get; set; }
    public virtual DbSet<RedesSocialesPublicacion> RedesSocialesPublicaciones { get; set; }
    public virtual DbSet<TelefonosPublicacion> TelefonosPublicaciones { get; set; }
    public virtual DbSet<TiposLinkMultimedia> TiposLinkMultimedias { get; set; }
    public virtual DbSet<WhatsappsPublicacion> WhatsappsPublicaciones { get; set; }

    // 🏪 Negocios
    public virtual DbSet<Negocio> Negocios { get; set; }

    // 🎁 Paquetes
    public virtual DbSet<AsignacionesPaqueteUsuario> AsignacionesPaqueteUsuarios { get; set; }
    public virtual DbSet<DetallePublicacionPaquete> DetallePublicacionPaquetes { get; set; }
    public virtual DbSet<PagosPaquetePromocional> PagosPaquetePromocionales { get; set; }
    public virtual DbSet<PaquetesPromocional> PaquetesPromocionales { get; set; }

    // 📰 Publicaciones
    public virtual DbSet<CapturasTransaccionPublicacion> CapturasTransaccionPublicaciones { get; set; }
    public virtual DbSet<CategoriasPublicacion> CategoriasPublicaciones { get; set; }
    public virtual DbSet<DetallesPublicacion> DetallesPublicaciones { get; set; }
    public virtual DbSet<PreciosPublicacion> PreciosPublicaciones { get; set; }
    public virtual DbSet<Publicacion> Publicaciones { get; set; }
    public virtual DbSet<PublicacionesEnAcuerdo> PublicacionesEnAcuerdos { get; set; }
    public virtual DbSet<SubcategoriasPublicacion> SubcategoriasPublicaciones { get; set; }
    public virtual DbSet<TiposPublicacion> TiposPublicaciones { get; set; }

    // 🧑‍💼 Representantes
    public virtual DbSet<MeGustaRepresentante> MeGustaRepresentantes { get; set; }
    public virtual DbSet<MetaGlobalRespaldo> MetaGlobalRespaldo { get; set; }
    public virtual DbSet<Representante> Representantes { get; set; }
    public virtual DbSet<RepresentantesCampania> RepresentantesCampanias { get; set; }

    // 🔐 Roles
    public virtual DbSet<Rol> Roles { get; set; }
    public virtual DbSet<UsuariosRol> UsuariosRoles { get; set; }

    // 🧑‍🏫 Staff
    public virtual DbSet<AccionesAdministrador> AccionesAdministradores { get; set; }
    public virtual DbSet<StaffAdministrativo> StaffAdministrativos { get; set; }

    // 💳 Transacciones
    public virtual DbSet<TarifasAcuerdosComercial> TarifasAcuerdosComerciales { get; set; }
    public virtual DbSet<TarifasPublicacion> TarifasPublicaciones { get; set; }
    public virtual DbSet<TransaccionesAcuerdo> TransaccionesAcuerdos { get; set; }
    public virtual DbSet<TransaccionesPublicacion> TransaccionesPublicaciones { get; set; }

    // 🌍 Ubicación del sistema
    public virtual DbSet<LugaresReferencia> LugaresReferencias { get; set; }
    public virtual DbSet<UbicacionesSistema> UbicacionesSistemas { get; set; }

    // 👤 Usuarios
    public virtual DbSet<Usuario> Usuarios { get; set; }
    public virtual DbSet<DatosPrivadosRepresentante> DatosPrivadosRepresentantes { get; set; }
    public virtual DbSet<DatosUsuario> DatosUsuarios { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Leer la cadena de conexión desde appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = configuration.GetConnectionString("CadenaSQL");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccionesAdministrador>(entity =>
        {
            entity.HasKey(e => e.IdAccion).HasName("PK__Acciones__387C456140860234");

            entity.ToTable("AccionesAdministrador");

            entity.Property(e => e.IdAccion).HasColumnName("id_accion");
            entity.Property(e => e.FechaAccion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_accion");
            entity.Property(e => e.IdDatosUsuario).HasColumnName("id_datos_usuario");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.TipoAccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_accion");

            entity.HasOne(d => d.IdDatosUsuarioNavigation).WithMany(p => p.AccionesAdministradors)
                .HasForeignKey(d => d.IdDatosUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AccionesA__id_da__55BFB948");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.AccionesAdministradors)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AccionesA__id_ro__56B3DD81");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.AccionesAdministradors)
                .HasForeignKey(d => d.IdStaff)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AccionesA__id_st__54CB950F");
        });

        modelBuilder.Entity<AcuerdosComercial>(entity =>
        {
            entity.HasKey(e => e.IdAcuerdo).HasName("PK__Acuerdos__106B829C9CD234AB");

            entity.Property(e => e.IdAcuerdo).HasColumnName("id_acuerdo");
            entity.Property(e => e.DiasGracia)
                .HasDefaultValue(0)
                .HasColumnName("dias_gracia");
            entity.Property(e => e.EstadoAcuerdo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("activo")
                .HasColumnName("estado_acuerdo");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdDatosUsuario).HasColumnName("id_datos_usuario");
            entity.Property(e => e.IdTarifaAcuerdo).HasColumnName("id_tarifa_acuerdo");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.PublicacionesDisponibles).HasColumnName("publicaciones_disponibles");

            entity.HasOne(d => d.IdDatosUsuarioNavigation).WithMany(p => p.AcuerdosComerciales)
                .HasForeignKey(d => d.IdDatosUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AcuerdosC__id_da__178D7CA5");

            entity.HasOne(d => d.IdTarifaAcuerdoNavigation).WithMany(p => p.AcuerdosComerciales)
                .HasForeignKey(d => d.IdTarifaAcuerdo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AcuerdosC__id_ta__1881A0DE");
        });

        modelBuilder.Entity<ArchivosAdjuntosPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdArchivo).HasName("PK__Archivos__9B69644317E3A9AB");

            entity.ToTable("ArchivosAdjuntosPublicacion");

            entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Extension)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("extension");
            entity.Property(e => e.FechaSubida)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_subida");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre_archivo");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.ArchivosAdjuntosPublicacions)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ArchivosA__id_pu__442B18F2");
        });

        modelBuilder.Entity<AsignacionesPaqueteUsuario>(entity =>
        {
            entity.HasKey(e => e.IdAsignacion).HasName("PK__Asignaci__C3F7F966BEF17692");

            entity.ToTable("AsignacionesPaqueteUsuario");

            entity.Property(e => e.IdAsignacion).HasColumnName("id_asignacion");
            entity.Property(e => e.EstadoAsignacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("activo")
                .HasColumnName("estado_asignacion");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.IdDatosUsuario).HasColumnName("id_datos_usuario");
            entity.Property(e => e.IdPaquete).HasColumnName("id_paquete");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.PublicacionesUsadas)
                .HasDefaultValue(0)
                .HasColumnName("publicaciones_usadas");

            entity.HasOne(d => d.IdDatosUsuarioNavigation).WithMany(p => p.AsignacionesPaqueteUsuarios)
                .HasForeignKey(d => d.IdDatosUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asignacio__id_da__3DB3258D");

            entity.HasOne(d => d.IdPaqueteNavigation).WithMany(p => p.AsignacionesPaqueteUsuarios)
                .HasForeignKey(d => d.IdPaquete)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asignacio__id_pa__3CBF0154");
        });

        modelBuilder.Entity<Aviso>(entity =>
        {
            entity.HasKey(e => e.IdAviso).HasName("PK__Avisos__66D8457B4C2E9060");

            entity.HasIndex(e => e.IdPublicacion, "UQ__Avisos__7C385172AA6F5F76").IsUnique();

            entity.Property(e => e.IdAviso).HasColumnName("id_aviso");
            entity.Property(e => e.Condiciones)
                .HasColumnType("text")
                .HasColumnName("condiciones");
            entity.Property(e => e.EsNegociable)
                .HasDefaultValue(false)
                .HasColumnName("es_negociable");
            entity.Property(e => e.FechaDisponible)
                .HasColumnType("datetime")
                .HasColumnName("fecha_disponible");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.FormaPago)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("forma_pago");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.Modalidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modalidad");
            entity.Property(e => e.TipoAviso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_aviso");

            entity.HasOne(d => d.IdPublicacionNavigation).WithOne(p => p.Aviso)
                .HasForeignKey<Aviso>(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Avisos__id_publi__01342732");
        });

        modelBuilder.Entity<CampaniasElectoral>(entity =>
        {
            entity.HasKey(e => e.IdCampania).HasName("PK__Campania__57EB0A9F827B14B4");

            entity.Property(e => e.IdCampania)
                .ValueGeneratedNever()
                .HasColumnName("id_campania");
            entity.Property(e => e.NivelElectoral)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nivel_electoral");

            entity.HasOne(d => d.IdCampaniaNavigation).WithOne(p => p.CampaniasElectorale)
                .HasForeignKey<CampaniasElectoral>(d => d.IdCampania)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Campanias__id_ca__7C1A6C5A");
        });

        modelBuilder.Entity<CampaniasPromocional>(entity =>
        {
            entity.HasKey(e => e.IdCampania).HasName("PK__Campania__57EB0A9F90D0C42B");

            entity.Property(e => e.IdCampania)
                .ValueGeneratedNever()
                .HasColumnName("id_campania");
            entity.Property(e => e.TipoPromocional)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_promocional");

            entity.HasOne(d => d.IdCampaniaNavigation).WithOne(p => p.CampaniasPromocionale)
                .HasForeignKey<CampaniasPromocional>(d => d.IdCampania)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Campanias__id_ca__69FBBC1F");
        });

        modelBuilder.Entity<Campania>(entity =>
        {
            entity.HasKey(e => e.IdCampania).HasName("PK__Campania__57EB0A9F26C4B29F");

            entity.Property(e => e.IdCampania).HasColumnName("id_campania");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("activo")
                .HasColumnName("estado");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.IdUbicacion).HasColumnName("id_ubicacion");
            entity.Property(e => e.TipoCampania)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("promocional")
                .HasColumnName("tipo_campania");
            entity.Property(e => e.Titulo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("titulo");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.Campania)
                .HasForeignKey(d => d.IdStaff)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Campania__id_sta__662B2B3B");

            entity.HasOne(d => d.IdUbicacionNavigation).WithMany(p => p.Campania)
                .HasForeignKey(d => d.IdUbicacion)
                .HasConstraintName("FK__Campania__id_ubi__65370702");
        });

        modelBuilder.Entity<CapturasTransaccionAcuerdo>(entity =>
        {
            entity.HasKey(e => e.IdCaptura).HasName("PK__Capturas__F82A7F3621DA11A4");

            entity.ToTable("CapturasTransaccionAcuerdo");

            entity.Property(e => e.IdCaptura).HasColumnName("id_captura");
            entity.Property(e => e.Contenido)
                .HasColumnType("text")
                .HasColumnName("contenido");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaSubida)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_subida");
            entity.Property(e => e.IdTransaccionAcuerdo).HasColumnName("id_transaccion_acuerdo");
            entity.Property(e => e.TipoCaptura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_captura");

            entity.HasOne(d => d.IdTransaccionAcuerdoNavigation).WithMany(p => p.CapturasTransaccionAcuerdos)
                .HasForeignKey(d => d.IdTransaccionAcuerdo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CapturasT__id_tr__2C88998B");
        });

        modelBuilder.Entity<CapturasTransaccionPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdCaptura).HasName("PK__Capturas__F82A7F3675957C5C");

            entity.ToTable("CapturasTransaccionPublicacion");

            entity.Property(e => e.IdCaptura).HasColumnName("id_captura");
            entity.Property(e => e.Contenido)
                .HasColumnType("text")
                .HasColumnName("contenido");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaSubida)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_subida");
            entity.Property(e => e.IdTransaccion).HasColumnName("id_transaccion");
            entity.Property(e => e.TipoCaptura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_captura");

            entity.HasOne(d => d.IdTransaccionNavigation).WithMany(p => p.CapturasTransaccionPublicacions)
                .HasForeignKey(d => d.IdTransaccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CapturasT__id_tr__13BCEBC1");
        });

        modelBuilder.Entity<CategoriasPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__CD54BC5AE2606139");

            entity.ToTable("CategoriasPublicacion");

            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_categoria");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.CategoriasPublicacions)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Categoria__id_ti__5C6CB6D7");
        });

        modelBuilder.Entity<Colaborador>(entity =>
        {
            entity.HasKey(e => e.IdColaborador).HasName("PK__Colabora__BA4DA94693E3E574");

            entity.HasIndex(e => e.IdDatosUsuario, "UQ__Colabora__62B630F4FA22220C").IsUnique();

            entity.Property(e => e.IdColaborador).HasColumnName("id_colaborador");
            entity.Property(e => e.Activo)
                .HasDefaultValue(false)
                .HasColumnName("activo");
            entity.Property(e => e.EstadoColaborador)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("estado_colaborador");
            entity.Property(e => e.FechaAprobacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_aprobacion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdDatosUsuario).HasColumnName("id_datos_usuario");
            entity.Property(e => e.IdStaffAprobador).HasColumnName("id_staff_aprobador");
            entity.Property(e => e.MetodoIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("metodo_ingreso");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdDatosUsuarioNavigation).WithOne(p => p.Colaboradore)
                .HasForeignKey<Colaborador>(d => d.IdDatosUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Colaborad__id_da__48EFCE0F");

            entity.HasOne(d => d.IdStaffAprobadorNavigation).WithMany(p => p.Colaboradores)
                .HasForeignKey(d => d.IdStaffAprobador)
                .HasConstraintName("FK__Colaborad__id_st__4BCC3ABA");
        });

        modelBuilder.Entity<ContactosAdicionalesPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdContacto).HasName("PK__Contacto__099A52B8AA0D7ED7");

            entity.ToTable("ContactosAdicionalesPublicacion");

            entity.Property(e => e.IdContacto).HasColumnName("id_contacto");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.TipoContacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_contacto");
            entity.Property(e => e.ValorContacto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("valor_contacto");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.ContactosAdicionalesPublicacions)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contactos__id_pu__10766AC2");
        });

        modelBuilder.Entity<DatosEmpresa>(entity =>
        {
            entity.HasKey(e => e.IdDatosUsuario).HasName("PK__DatosEmp__62B630F568871E60");

            entity.ToTable("DatosEmpresa");

            entity.HasIndex(e => e.Ruc, "UQ__DatosEmp__C2B74E6198C8BA4F").IsUnique();

            entity.Property(e => e.IdDatosUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_datos_usuario");
            entity.Property(e => e.PaginaWeb)
                .HasColumnType("text")
                .HasColumnName("pagina_web");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("razon_social");
            entity.Property(e => e.Ruc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ruc");

            entity.HasOne(d => d.IdDatosUsuarioNavigation).WithOne(p => p.DatosEmpresa)
                .HasForeignKey<DatosEmpresa>(d => d.IdDatosUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DatosEmpr__id_da__151B244E");
        });

        modelBuilder.Entity<DatosPersona>(entity =>
        {
            entity.HasKey(e => e.IdDatosUsuario).HasName("PK__DatosPer__62B630F5398044CE");

            entity.ToTable("DatosPersona");

            entity.HasIndex(e => e.Dni, "UQ__DatosPer__D87608A7DAB9E803").IsUnique();

            entity.Property(e => e.IdDatosUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_datos_usuario");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido_materno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido_paterno");
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");

            entity.HasOne(d => d.IdDatosUsuarioNavigation).WithOne(p => p.DatosPersona)
                .HasForeignKey<DatosPersona>(d => d.IdDatosUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DatosPers__id_da__114A936A");
        });

        modelBuilder.Entity<DatosPrivadosRepresentante>(entity =>
        {
            entity.HasKey(e => e.IdDatoPrivado).HasName("PK__DatosPri__24AE95F41878557E");

            entity.ToTable("DatosPrivadosRepresentante");

            entity.HasIndex(e => e.IdRepresentante, "UQ__DatosPri__39352884447DE703").IsUnique();

            entity.Property(e => e.IdDatoPrivado).HasColumnName("id_dato_privado");
            entity.Property(e => e.CorreoPersonal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correo_personal");
            entity.Property(e => e.DireccionResidencia)
                .HasColumnType("text")
                .HasColumnName("direccion_residencia");
            entity.Property(e => e.DocumentoIdentidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento_identidad");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.IdRepresentante).HasColumnName("id_representante");
            entity.Property(e => e.TelefonoPersonal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono_personal");

            entity.HasOne(d => d.IdRepresentanteNavigation).WithOne(p => p.DatosPrivadosRepresentante)
                .HasForeignKey<DatosPrivadosRepresentante>(d => d.IdRepresentante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DatosPriv__id_re__1EF99443");
        });

        modelBuilder.Entity<DatosUsuario>(entity =>
        {
            entity.HasKey(e => e.IdDatosUsuario).HasName("PK__DatosUsu__62B630F5834C6C13");

            entity.ToTable("DatosUsuario");

            entity.HasIndex(e => e.IdUsuario, "UQ__DatosUsu__4E3E04AC987D4892").IsUnique();

            entity.Property(e => e.IdDatosUsuario).HasColumnName("id_datos_usuario");
            entity.Property(e => e.Celular)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.Direccion)
                .HasColumnType("text")
                .HasColumnName("direccion");
            entity.Property(e => e.EstadoColaborador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("ninguno")
                .HasColumnName("estado_colaborador");
            entity.Property(e => e.EstadoGeneral)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("activo")
                .HasColumnName("estado_general");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.ImagenPerfil)
                .HasColumnType("text")
                .HasColumnName("imagen_perfil");
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo_usuario");

            entity.HasOne(d => d.IdUsuarioNavigation).WithOne(p => p.DatosUsuario)
                .HasForeignKey<DatosUsuario>(d => d.IdUsuario)
                .HasConstraintName("FK__DatosUsua__id_us__08B54D69");
        });

        modelBuilder.Entity<DetallePublicacionPaquete>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("PK__DetalleP__4F1332DE1260884E");

            entity.ToTable("DetallePublicacionPaquete");

            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.FechaUso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_uso");
            entity.Property(e => e.IdAsignacion).HasColumnName("id_asignacion");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");

            entity.HasOne(d => d.IdAsignacionNavigation).WithMany(p => p.DetallePublicacionPaquetes)
                .HasForeignKey(d => d.IdAsignacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetallePu__id_as__436BFEE3");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.DetallePublicacionPaquetes)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetallePu__id_pu__4460231C");
        });

        modelBuilder.Entity<DetallesPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("PK__Detalles__4F1332DE2237FEF9");

            entity.ToTable("DetallesPublicacion");

            entity.HasIndex(e => e.IdPublicacion, "UQ__Detalles__7C385172E71808C8").IsUnique();

            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.Titulo)
                .HasColumnType("text")
                .HasColumnName("titulo");

            entity.HasOne(d => d.IdPublicacionNavigation).WithOne(p => p.DetallesPublicacion)
                .HasForeignKey<DetallesPublicacion>(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetallesP__id_pu__0AF29B96");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.IdEvento).HasName("PK__Eventos__AF150CA55DC8A2C8");

            entity.HasIndex(e => e.IdPublicacion, "UQ__Eventos__7C38517225049F00").IsUnique();

            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.FechaFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.Lugar)
                .HasColumnType("text")
                .HasColumnName("lugar");
            entity.Property(e => e.TipoEvento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tipo_evento");

            entity.HasOne(d => d.IdPublicacionNavigation).WithOne(p => p.Evento)
                .HasForeignKey<Evento>(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Eventos__id_publ__5CC1BC92");
        });

        modelBuilder.Entity<FechasImportantes>(entity =>
        {
            entity.HasKey(e => e.IdFechaImportante).HasName("PK__FechasIm__80C5E65F4692A518");

            entity.Property(e => e.IdFechaImportante).HasColumnName("id_fecha_importante");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdColaborador).HasColumnName("id_colaborador");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.IdTipoFecha).HasColumnName("id_tipo_fecha");
            entity.Property(e => e.IdUbicacion).HasColumnName("id_ubicacion");
            entity.Property(e => e.Titulo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("titulo");

            entity.HasOne(d => d.IdColaboradorNavigation).WithMany(p => p.FechasImportantes)
                .HasForeignKey(d => d.IdColaborador)
                .HasConstraintName("FK__FechasImp__id_co__34B3CB38");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.FechasImportantes)
                .HasForeignKey(d => d.IdStaff)
                .HasConstraintName("FK__FechasImp__id_st__379037E3");

            entity.HasOne(d => d.IdTipoFechaNavigation).WithMany(p => p.FechasImportantes)
                .HasForeignKey(d => d.IdTipoFecha)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FechasImp__id_ti__35A7EF71");

            entity.HasOne(d => d.IdUbicacionNavigation).WithMany(p => p.FechasImportantes)
                .HasForeignKey(d => d.IdUbicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FechasImp__id_ub__369C13AA");
        });

        modelBuilder.Entity<GanadoresCampaniaPromocional>(entity =>
        {
            entity.HasKey(e => e.IdGanador).HasName("PK__Ganadore__610E2FDF504627E9");

            entity.ToTable("GanadoresCampaniaPromocional");

            entity.Property(e => e.IdGanador).HasColumnName("id_ganador");
            entity.Property(e => e.FechaGanador)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_ganador");
            entity.Property(e => e.IdCampania).HasColumnName("id_campania");
            entity.Property(e => e.IdParticipante).HasColumnName("id_participante");
            entity.Property(e => e.IdPremio).HasColumnName("id_premio");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCampaniaNavigation).WithMany(p => p.GanadoresCampaniaPromocionals)
                .HasForeignKey(d => d.IdCampania)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ganadores__id_ca__76619304");

            entity.HasOne(d => d.IdParticipanteNavigation).WithMany(p => p.GanadoresCampaniaPromocionals)
                .HasForeignKey(d => d.IdParticipante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ganadores__id_pa__7755B73D");

            entity.HasOne(d => d.IdPremioNavigation).WithMany(p => p.GanadoresCampaniaPromocionals)
                .HasForeignKey(d => d.IdPremio)
                .HasConstraintName("FK__Ganadores__id_pr__7849DB76");
        });

        modelBuilder.Entity<HistorialCargosRepresentante>(entity =>
        {
            entity.HasKey(e => e.IdHistorial).HasName("PK__Historia__76E6C50290A6317F");

            entity.ToTable("HistorialCargosRepresentante");

            entity.Property(e => e.IdHistorial).HasColumnName("id_historial");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Entidad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("entidad");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.IdRepresentante).HasColumnName("id_representante");
            entity.Property(e => e.NombreCargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_cargo");

            entity.HasOne(d => d.IdRepresentanteNavigation).WithMany(p => p.HistorialCargosRepresentantes)
                .HasForeignKey(d => d.IdRepresentante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__id_re__21D600EE");
        });

        modelBuilder.Entity<HistorialEstadosPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdHistorialEstado).HasName("PK__Historia__A872686B48CF6C56");

            entity.ToTable("HistorialEstadosPublicacion");

            entity.Property(e => e.IdHistorialEstado).HasColumnName("id_historial_estado");
            entity.Property(e => e.EstadoAnterior)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("estado_anterior");
            entity.Property(e => e.EstadoNuevo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("estado_nuevo");
            entity.Property(e => e.FechaCambio)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_cambio");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.MotivoCambio)
                .HasColumnType("text")
                .HasColumnName("motivo_cambio");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.HistorialEstadosPublicacions)
                .HasForeignKey(d => d.IdPublicacion)
                .HasConstraintName("FK__Historial__id_pu__04459E07");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.HistorialEstadosPublicacions)
                .HasForeignKey(d => d.IdStaff)
                .HasConstraintName("FK__Historial__id_st__062DE679");
        });

        modelBuilder.Entity<HistorialEstadosTransaccion>(entity =>
        {
            entity.HasKey(e => e.IdHistorialEstado).HasName("PK__Historia__A872686BAB1B41BC");

            entity.ToTable("HistorialEstadosTransaccion");

            entity.Property(e => e.IdHistorialEstado).HasColumnName("id_historial_estado");
            entity.Property(e => e.EstadoAnterior)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("estado_anterior");
            entity.Property(e => e.EstadoNuevo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("estado_nuevo");
            entity.Property(e => e.FechaCambio)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_cambio");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.IdTransaccion).HasColumnName("id_transaccion");
            entity.Property(e => e.MotivoCambio)
                .HasColumnType("text")
                .HasColumnName("motivo_cambio");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.HistorialEstadosTransaccions)
                .HasForeignKey(d => d.IdStaff)
                .HasConstraintName("FK__Historial__id_st__6991A7CB");

            entity.HasOne(d => d.IdTransaccionNavigation).WithMany(p => p.HistorialEstadosTransaccions)
                .HasForeignKey(d => d.IdTransaccion)
                .HasConstraintName("FK__Historial__id_tr__67A95F59");
        });

        modelBuilder.Entity<HistorialModificacionesAcuerdo>(entity =>
        {
            entity.HasKey(e => e.IdHistorial).HasName("PK__Historia__76E6C5028E71C3F2");

            entity.ToTable("HistorialModificacionesAcuerdo");

            entity.Property(e => e.IdHistorial).HasColumnName("id_historial");
            entity.Property(e => e.CampoModificado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("campo_modificado");
            entity.Property(e => e.FechaModificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_modificacion");
            entity.Property(e => e.IdAcuerdo).HasColumnName("id_acuerdo");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.Motivo)
                .HasColumnType("text")
                .HasColumnName("motivo");
            entity.Property(e => e.ValorAnterior)
                .HasColumnType("text")
                .HasColumnName("valor_anterior");
            entity.Property(e => e.ValorNuevo)
                .HasColumnType("text")
                .HasColumnName("valor_nuevo");

            entity.HasOne(d => d.IdAcuerdoNavigation).WithMany(p => p.HistorialModificacionesAcuerdos)
                .HasForeignKey(d => d.IdAcuerdo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__id_ac__30592A6F");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.HistorialModificacionesAcuerdos)
                .HasForeignKey(d => d.IdStaff)
                .HasConstraintName("FK__Historial__id_st__314D4EA8");
        });

        modelBuilder.Entity<HistorialPostulacionesColaborador>(entity =>
        {
            entity.HasKey(e => e.IdHistorial).HasName("PK__Historia__76E6C502F5F194C8");

            entity.ToTable("HistorialPostulacionesColaborador");

            entity.Property(e => e.IdHistorial).HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdPostulacion).HasColumnName("id_postulacion");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.NuevoEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nuevo_estado");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdPostulacionNavigation).WithMany(p => p.HistorialPostulacionesColaboradors)
                .HasForeignKey(d => d.IdPostulacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__id_po__5555A4F4");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.HistorialPostulacionesColaboradors)
                .HasForeignKey(d => d.IdStaff)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__id_st__5649C92D");
        });

        modelBuilder.Entity<HistorialPublicacionFecha>(entity =>
        {
            entity.HasKey(e => e.IdHistorialFecha).HasName("PK__Historia__6DA3C0B192F467B5");

            entity.Property(e => e.IdHistorialFecha).HasColumnName("id_historial_fecha");
            entity.Property(e => e.FechaAplicada)
                .HasColumnType("datetime")
                .HasColumnName("fecha_aplicada");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.IdTransaccion).HasColumnName("id_transaccion");
            entity.Property(e => e.Observacion)
                .HasColumnType("text")
                .HasColumnName("observacion");
            entity.Property(e => e.TipoFecha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_fecha");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.HistorialPublicacionFechas)
                .HasForeignKey(d => d.IdPublicacion)
                .HasConstraintName("FK__Historial__id_pu__4DE98D56");

            entity.HasOne(d => d.IdTransaccionNavigation).WithMany(p => p.HistorialPublicacionFechas)
                .HasForeignKey(d => d.IdTransaccion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Historial__id_tr__4FD1D5C8");
        });

        modelBuilder.Entity<Interes>(entity =>
        {
            entity.HasKey(e => e.IdInteres).HasName("PK__Interese__597C1869B6146652");

            entity.HasIndex(e => e.NombreInteres, "UQ__Interese__EC1954535AE85C50").IsUnique();

            entity.Property(e => e.IdInteres).HasColumnName("id_interes");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.NombreInteres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_interes");
            entity.Property(e => e.VisiblePublicamente)
                .HasDefaultValue(true)
                .HasColumnName("visible_publicamente");
        });

        modelBuilder.Entity<InteresesPublicacion>(entity =>
        {
            entity.HasKey(e => new { e.IdPublicacion, e.IdInteres }).HasName("PK__Interese__F9AF90F59A6078B9");

            entity.ToTable("InteresesPublicacion");

            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.IdInteres).HasColumnName("id_interes");
            entity.Property(e => e.FechaEtiquetado)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_etiquetado");

            entity.HasOne(d => d.IdInteresNavigation).WithMany(p => p.InteresesPublicacions)
                .HasForeignKey(d => d.IdInteres)
                .HasConstraintName("FK__Intereses__id_in__76EBA2E9");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.InteresesPublicacions)
                .HasForeignKey(d => d.IdPublicacion)
                .HasConstraintName("FK__Intereses__id_pu__75F77EB0");
        });

        modelBuilder.Entity<InteresesUsuario>(entity =>
        {
            entity.HasKey(e => new { e.IdDatosUsuario, e.IdInteres }).HasName("PK__Interese__E721F173883DFBAC");

            entity.ToTable("InteresesUsuario");

            entity.Property(e => e.IdDatosUsuario).HasColumnName("id_datos_usuario");
            entity.Property(e => e.IdInteres).HasColumnName("id_interes");
            entity.Property(e => e.FechaAsignacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_asignacion");

            entity.HasOne(d => d.IdDatosUsuarioNavigation).WithMany(p => p.InteresesUsuarios)
                .HasForeignKey(d => d.IdDatosUsuario)
                .HasConstraintName("FK__Intereses__id_da__6C390A4C");

            entity.HasOne(d => d.IdInteresNavigation).WithMany(p => p.InteresesUsuarios)
                .HasForeignKey(d => d.IdInteres)
                .HasConstraintName("FK__Intereses__id_in__6D2D2E85");
        });

        modelBuilder.Entity<LinksMultimedia>(entity =>
        {
            entity.HasKey(e => e.IdLink).HasName("PK__LinksMul__99847A445EB497E9");

            entity.Property(e => e.IdLink).HasColumnName("id_link");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
            entity.Property(e => e.VisiblePublicamente)
                .HasDefaultValue(true)
                .HasColumnName("visible_publicamente");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.LinksMultimedia)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LinksMult__id_pu__38B96646");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.LinksMultimedia)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LinksMult__id_ti__39AD8A7F");
        });

        modelBuilder.Entity<LugaresReferencia>(entity =>
        {
            entity.HasKey(e => e.IdLugar).HasName("PK__LugaresR__B172B1F8411911FC");

            entity.Property(e => e.IdLugar).HasColumnName("id_lugar");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.IdUbicacion).HasColumnName("id_ubicacion");
            entity.Property(e => e.NombreLugar)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre_lugar");
            entity.Property(e => e.ReferenciaMapa)
                .HasColumnType("text")
                .HasColumnName("referencia_mapa");
            entity.Property(e => e.VisibleEnPortal)
                .HasDefaultValue(true)
                .HasColumnName("visible_en_portal");

            entity.HasOne(d => d.IdUbicacionNavigation).WithMany(p => p.LugaresReferencia)
                .HasForeignKey(d => d.IdUbicacion)
                .HasConstraintName("FK__LugaresRe__id_ub__398D8EEE");
        });

        modelBuilder.Entity<MeGustaRepresentante>(entity =>
        {
            entity.HasKey(e => e.IdClick).HasName("PK__MeGustaR__25729035B12DFAC1");

            entity.ToTable("MeGustaRepresentante");

            entity.Property(e => e.IdClick).HasColumnName("id_click");
            entity.Property(e => e.FechaClick)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_click");
            entity.Property(e => e.IdRepresentante).HasColumnName("id_representante");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdRepresentanteNavigation).WithMany(p => p.MeGustaRepresentantes)
                .HasForeignKey(d => d.IdRepresentante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MeGustaRe__id_re__05F8DC4F");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.MeGustaRepresentantes)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MeGustaRe__id_us__06ED0088");
        });

        modelBuilder.Entity<MetaGlobalRespaldo>(entity =>
        {
            entity.HasKey(e => e.IdMeta).HasName("PK__MetaGlob__68A1E9B8F8A3BE44");

            entity.ToTable("MetaGlobalRespaldo");

            entity.HasIndex(e => new { e.TipoCandidato, e.FechaMeta }, "uq_tipo_fecha").IsUnique();

            entity.Property(e => e.IdMeta).HasColumnName("id_meta");
            entity.Property(e => e.AjusteExtra)
                .HasDefaultValue(2)
                .HasColumnName("ajuste_extra");
            entity.Property(e => e.Comentario)
                .HasColumnType("text")
                .HasColumnName("comentario");
            entity.Property(e => e.FechaMeta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_meta");
            entity.Property(e => e.IdCampania).HasColumnName("id_campania");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.MetaFinal).HasColumnName("meta_final");
            entity.Property(e => e.TipoCandidato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_candidato");
            entity.Property(e => e.ValorMaximoDetectado).HasColumnName("valor_maximo_detectado");

            entity.HasOne(d => d.IdCampaniaNavigation).WithMany(p => p.MetaGlobalRespaldos)
                .HasForeignKey(d => d.IdCampania)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MetaGloba__id_ca__16CE6296");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.MetaGlobalRespaldos)
                .HasForeignKey(d => d.IdStaff)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MetaGloba__id_st__1A9EF37A");
        });

        modelBuilder.Entity<MultimediaPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdMultimedia).HasName("PK__Multimed__89C12EF659FCF22A");

            entity.ToTable("MultimediaPublicacion");

            entity.Property(e => e.IdMultimedia).HasColumnName("id_multimedia");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaSubida)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_subida");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.Orden)
                .HasDefaultValue(1)
                .HasColumnName("orden");
            entity.Property(e => e.TipoMedia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_media");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
            entity.Property(e => e.VisiblePublicamente)
                .HasDefaultValue(true)
                .HasColumnName("visible_publicamente");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.MultimediaPublicacions)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Multimedi__id_pu__3E723F9C");
        });

        modelBuilder.Entity<Negocio>(entity =>
        {
            entity.HasKey(e => e.IdNegocio).HasName("PK__Negocios__01F7B7426BCBAA30");

            entity.HasIndex(e => e.IdPublicacion, "UQ__Negocios__7C3851727DE76B87").IsUnique();

            entity.Property(e => e.IdNegocio).HasColumnName("id_negocio");
            entity.Property(e => e.DeliveryDisponible)
                .HasDefaultValue(false)
                .HasColumnName("delivery_disponible");
            entity.Property(e => e.DescripcionServicio)
                .HasColumnType("text")
                .HasColumnName("descripcion_servicio");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.FormatoVenta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("formato_venta");
            entity.Property(e => e.HorarioAtencion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("horario_atencion");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.NombreNegocio)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre_negocio");
            entity.Property(e => e.PaginaWeb)
                .HasColumnType("text")
                .HasColumnName("pagina_web");
            entity.Property(e => e.TipoNegocio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tipo_negocio");

            entity.HasOne(d => d.IdPublicacionNavigation).WithOne(p => p.Negocio)
                .HasForeignKey<Negocio>(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Negocios__id_pub__618671AF");
        });

        modelBuilder.Entity<PagosPaquetePromocional>(entity =>
        {
            entity.HasKey(e => e.IdPagoPaquete).HasName("PK__PagosPaq__B6B3765DF4940C2C");

            entity.ToTable("PagosPaquetePromocional");

            entity.Property(e => e.IdPagoPaquete).HasColumnName("id_pago_paquete");
            entity.Property(e => e.EstadoPago)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("confirmado")
                .HasColumnName("estado_pago");
            entity.Property(e => e.FechaPago)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.IdAsignacion).HasColumnName("id_asignacion");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("metodo_pago");
            entity.Property(e => e.MontoPagado)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto_pagado");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.ReferenciaPago)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("referencia_pago");

            entity.HasOne(d => d.IdAsignacionNavigation).WithMany(p => p.PagosPaquetePromocionals)
                .HasForeignKey(d => d.IdAsignacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PagosPaqu__id_as__33F4B129");
        });

        modelBuilder.Entity<PaquetesPromocional>(entity =>
        {
            entity.HasKey(e => e.IdPaquete).HasName("PK__Paquetes__609C3BCBCBA5FB96");

            entity.Property(e => e.IdPaquete).HasColumnName("id_paquete");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.DuracionDias).HasColumnName("duracion_dias");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.PrecioTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_total");
            entity.Property(e => e.PublicacionesIncluidas).HasColumnName("publicaciones_incluidas");
            entity.Property(e => e.VisiblePublicamente)
                .HasDefaultValue(true)
                .HasColumnName("visible_publicamente");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.PaquetesPromocionales)
                .HasForeignKey(d => d.IdStaff)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PaquetesP__id_st__37FA4C37");
        });

        modelBuilder.Entity<ParticipacionColaborador>(entity =>
        {
            entity.HasKey(e => e.IdParticipacion).HasName("PK__Particip__E42D0FE09A32B206");

            entity.ToTable("ParticipacionColaborador");

            entity.Property(e => e.IdParticipacion).HasColumnName("id_participacion");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaParticipacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_participacion");
            entity.Property(e => e.IdColaborador).HasColumnName("id_colaborador");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.TipoParticipacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipo_participacion");

            entity.HasOne(d => d.IdColaboradorNavigation).WithMany(p => p.ParticipacionColaboradors)
                .HasForeignKey(d => d.IdColaborador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Participa__id_co__2EFAF1E2");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.ParticipacionColaboradors)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Participa__id_pu__2FEF161B");
        });

        modelBuilder.Entity<ParticipantesCampaniaPromocional>(entity =>
        {
            entity.HasKey(e => e.IdParticipante).HasName("PK__Particip__A88054DCDACA86AD");

            entity.ToTable("ParticipantesCampaniaPromocional");

            entity.HasIndex(e => e.CodigoTicket, "UQ__Particip__4FFCECF6681001D3").IsUnique();

            entity.Property(e => e.IdParticipante).HasColumnName("id_participante");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido_materno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido_paterno");
            entity.Property(e => e.CodigoTicket)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo_ticket");
            entity.Property(e => e.Direccion)
                .HasColumnType("text")
                .HasColumnName("direccion");
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdCampania).HasColumnName("id_campania");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdCampaniaNavigation).WithMany(p => p.ParticipantesCampaniaPromocionals)
                .HasForeignKey(d => d.IdCampania)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Participa__id_ca__6EC0713C");
        });

        modelBuilder.Entity<PerfilColaboradorExtendido>(entity =>
        {
            entity.HasKey(e => e.IdPerfil).HasName("PK__PerfilCo__1D1C876854809D2D");

            entity.ToTable("PerfilColaboradorExtendido");

            entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");
            entity.Property(e => e.CualidadesLiderazgo)
                .HasColumnType("text")
                .HasColumnName("cualidades_liderazgo");
            entity.Property(e => e.EnlacesRedes)
                .HasColumnType("text")
                .HasColumnName("enlaces_redes");
            entity.Property(e => e.IdColaborador).HasColumnName("id_colaborador");
            entity.Property(e => e.MensajePromocional)
                .HasColumnType("text")
                .HasColumnName("mensaje_promocional");
            entity.Property(e => e.ResumenPersonal)
                .HasColumnType("text")
                .HasColumnName("resumen_personal");

            entity.HasOne(d => d.IdColaboradorNavigation).WithMany(p => p.PerfilColaboradorExtendidos)
                .HasForeignKey(d => d.IdColaborador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PerfilCol__id_co__5A1A5A11");
        });

        modelBuilder.Entity<PostulacionesColaborador>(entity =>
        {
            entity.HasKey(e => e.IdPostulacion).HasName("PK__Postulac__533D250EC567A921");

            entity.ToTable("PostulacionesColaborador");

            entity.Property(e => e.IdPostulacion).HasColumnName("id_postulacion");
            entity.Property(e => e.DescripcionPostulacion)
                .HasColumnType("text")
                .HasColumnName("descripcion_postulacion");
            entity.Property(e => e.EstadoPostulacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("estado_postulacion");
            entity.Property(e => e.FechaPostulacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_postulacion");
            entity.Property(e => e.IdDatosUsuario).HasColumnName("id_datos_usuario");

            entity.HasOne(d => d.IdDatosUsuarioNavigation).WithMany(p => p.PostulacionesColaboradors)
                .HasForeignKey(d => d.IdDatosUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Postulaci__id_da__5090EFD7");
        });

        modelBuilder.Entity<PreciosPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdPrecio).HasName("PK__PreciosP__A70EF6ED165F1787");

            entity.ToTable("PreciosPublicacion");

            entity.Property(e => e.IdPrecio).HasColumnName("id_precio");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.IdTarifa).HasColumnName("id_tarifa");
            entity.Property(e => e.IdTransaccion).HasColumnName("id_transaccion");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.PreciosPublicacions)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PreciosPu__id_pu__60FC61CA");

            entity.HasOne(d => d.IdTarifaNavigation).WithMany(p => p.PreciosPublicacions)
                .HasForeignKey(d => d.IdTarifa)
                .HasConstraintName("FK__PreciosPu__id_ta__63D8CE75");

            entity.HasOne(d => d.IdTransaccionNavigation).WithMany(p => p.PreciosPublicacions)
                .HasForeignKey(d => d.IdTransaccion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__PreciosPu__id_tr__62E4AA3C");
        });

        modelBuilder.Entity<PremiosCampaniaPromocional>(entity =>
        {
            entity.HasKey(e => e.IdPremio).HasName("PK__PremiosC__A98947453B16E068");

            entity.ToTable("PremiosCampaniaPromocional");

            entity.Property(e => e.IdPremio).HasColumnName("id_premio");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.IdCampania).HasColumnName("id_campania");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.OrdenEntrega)
                .HasDefaultValue(1)
                .HasColumnName("orden_entrega");

            entity.HasOne(d => d.IdCampaniaNavigation).WithMany(p => p.PremiosCampaniaPromocionals)
                .HasForeignKey(d => d.IdCampania)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PremiosCa__id_ca__72910220");
        });

        modelBuilder.Entity<Publicacion>(entity =>
        {
            entity.HasKey(e => e.IdPublicacion).HasName("PK__Publicac__7C3851734D2F25A7");

            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.EstadoPublicacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("activo")
                .HasColumnName("estado_publicacion");
            entity.Property(e => e.FechaCambioEstado)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cambio_estado");
            entity.Property(e => e.IdDatosUsuario).HasColumnName("id_datos_usuario");
            entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.IdUbicacion).HasColumnName("id_ubicacion");

            entity.HasOne(d => d.IdDatosUsuarioNavigation).WithMany(p => p.Publicaciones)
                .HasForeignKey(d => d.IdDatosUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Publicaci__id_da__6225902D");

            entity.HasOne(d => d.IdSubcategoriaNavigation).WithMany(p => p.Publicaciones)
                .HasForeignKey(d => d.IdSubcategoria)
                .HasConstraintName("FK__Publicaci__id_su__640DD89F");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.Publicaciones)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Publicaci__id_ti__6319B466");

            entity.HasOne(d => d.IdUbicacionNavigation).WithMany(p => p.Publicaciones)
                .HasForeignKey(d => d.IdUbicacion)
                .HasConstraintName("FK__Publicaci__id_ub__6501FCD8");

            entity.HasMany(d => d.IdLugars).WithMany(p => p.IdPublicacions)
                .UsingEntity<Dictionary<string, object>>(
                    "PublicacionesLugaresReferencium",
                    r => r.HasOne<LugaresReferencia>().WithMany()
                        .HasForeignKey("IdLugar")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Publicaci__id_lu__7BB05806"),
                    l => l.HasOne<Publicacione>().WithMany()
                        .HasForeignKey("IdPublicacion")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Publicaci__id_pu__7ABC33CD"),
                    j =>
                    {
                        j.HasKey("IdPublicacion", "IdLugar").HasName("PK__Publicac__E72F7A6CDEE725C6");
                        j.ToTable("PublicacionesLugaresReferencia");
                        j.IndexerProperty<int>("IdPublicacion").HasColumnName("id_publicacion");
                        j.IndexerProperty<int>("IdLugar").HasColumnName("id_lugar");
                    });
        });

        modelBuilder.Entity<PublicacionesEnAcuerdo>(entity =>
        {
            entity.HasKey(e => e.IdRelacion).HasName("PK__Publicac__51F3AF4C991568B8");

            entity.ToTable("PublicacionesEnAcuerdo");

            entity.HasIndex(e => new { e.IdAcuerdo, e.IdPublicacion }, "uq_acuerdo_publicacion").IsUnique();

            entity.Property(e => e.IdRelacion).HasColumnName("id_relacion");
            entity.Property(e => e.FechaUso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_uso");
            entity.Property(e => e.IdAcuerdo).HasColumnName("id_acuerdo");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");

            entity.HasOne(d => d.IdAcuerdoNavigation).WithMany(p => p.PublicacionesEnAcuerdos)
                .HasForeignKey(d => d.IdAcuerdo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Publicaci__id_ac__2116E6DF");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.PublicacionesEnAcuerdos)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Publicaci__id_pu__220B0B18");
        });

        modelBuilder.Entity<ReconocimientosColaborador>(entity =>
        {
            entity.HasKey(e => e.IdReconocimiento).HasName("PK__Reconoci__280305671E5FCB73");

            entity.ToTable("ReconocimientosColaborador");

            entity.Property(e => e.IdReconocimiento).HasColumnName("id_reconocimiento");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaReconocimiento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_reconocimiento");
            entity.Property(e => e.IdColaborador).HasColumnName("id_colaborador");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.TipoReconocimiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_reconocimiento");
            entity.Property(e => e.TituloReconocimiento)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("titulo_reconocimiento");
            entity.Property(e => e.UrlConstancia)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("url_constancia");
            entity.Property(e => e.VisiblePublicamente)
                .HasDefaultValue(true)
                .HasColumnName("visible_publicamente");

            entity.HasOne(d => d.IdColaboradorNavigation).WithMany(p => p.ReconocimientosColaboradors)
                .HasForeignKey(d => d.IdColaborador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reconocim__id_co__2942188C");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.ReconocimientosColaboradors)
                .HasForeignKey(d => d.IdStaff)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reconocim__id_st__2A363CC5");
        });

        modelBuilder.Entity<RedesSocialesPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdRedSocial).HasName("PK__RedesSoc__AD6660992DBB6985");

            entity.ToTable("RedesSocialesPublicacion");

            entity.Property(e => e.IdRedSocial).HasColumnName("id_red_social");
            entity.Property(e => e.DescripcionOpcional)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion_opcional");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.Plataforma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("plataforma");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
            entity.Property(e => e.VisiblePublicamente)
                .HasDefaultValue(true)
                .HasColumnName("visible_publicamente");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.RedesSocialesPublicacions)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RedesSoci__id_pu__0CA5D9DE");
        });

        modelBuilder.Entity<Representante>(entity =>
        {
            entity.HasKey(e => e.IdRepresentante).HasName("PK__Represen__39352885BE8FE6EF");

            entity.HasIndex(e => e.IdPublicacion, "UQ__Represen__7C38517269FF674F").IsUnique();

            entity.Property(e => e.IdRepresentante).HasColumnName("id_representante");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.LemaPersonal)
                .HasColumnType("text")
                .HasColumnName("lema_personal");
            entity.Property(e => e.LugarTrabajo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("lugar_trabajo");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Profesion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("profesion");
            entity.Property(e => e.TipoCandidato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_candidato");
            entity.Property(e => e.VisiblePublicamente)
                .HasDefaultValue(true)
                .HasColumnName("visible_publicamente");

            entity.HasOne(d => d.IdPublicacionNavigation).WithOne(p => p.Representante)
                .HasForeignKey<Representante>(d => d.IdPublicacion)
                .HasConstraintName("FK__Represent__id_pu__147C05D0");
        });

        modelBuilder.Entity<RepresentantesCampania>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Represen__3213E83F4CA85F05");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCampania).HasColumnName("id_campania");
            entity.Property(e => e.IdRepresentante).HasColumnName("id_representante");

            entity.HasOne(d => d.IdCampaniaNavigation).WithMany(p => p.RepresentantesCampania)
                .HasForeignKey(d => d.IdCampania)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Represent__id_ca__1B29035F");

            entity.HasOne(d => d.IdRepresentanteNavigation).WithMany(p => p.RepresentantesCampania)
                .HasForeignKey(d => d.IdRepresentante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Represent__id_re__1A34DF26");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Roles__6ABCB5E0E11F98E6");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Uso)
                .HasColumnType("text")
                .HasColumnName("uso");
        });

        modelBuilder.Entity<StaffAdministrativo>(entity =>
        {
            entity.HasKey(e => e.IdStaff).HasName("PK__StaffAdm__12FEDA3CBD0067A4");

            entity.ToTable("StaffAdministrativo");

            entity.HasIndex(e => e.IdDatosUsuario, "UQ__StaffAdm__62B630F4B91D030A").IsUnique();

            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido_materno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido_paterno");
            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area");
            entity.Property(e => e.Cargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdDatosUsuario).HasColumnName("id_datos_usuario");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.SuperAdmin)
                .HasDefaultValue(false)
                .HasColumnName("super_admin");

            entity.HasOne(d => d.IdDatosUsuarioNavigation).WithOne(p => p.StaffAdministrativo)
                .HasForeignKey<StaffAdministrativo>(d => d.IdDatosUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StaffAdmi__id_da__18EBB532");
        });

        modelBuilder.Entity<SubcategoriasPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdSubcategoria).HasName("PK__Subcateg__FDB38B9E4A6F4F7A");

            entity.ToTable("SubcategoriasPublicacion");

            entity.Property(e => e.IdSubcategoria).HasColumnName("id_subcategoria");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.NombreSubcategoria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_subcategoria");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.SubcategoriasPublicacions)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Subcatego__id_ca__5F492382");
        });

        modelBuilder.Entity<TarifasAcuerdosComercial>(entity =>
        {
            entity.HasKey(e => e.IdTarifaAcuerdo).HasName("PK__TarifasA__20C7B75512B9C7CC");

            entity.HasIndex(e => new { e.IdTipo, e.FechaInicio }, "uq_tarifa_acuerdo_tipo_fecha").IsUnique();

            entity.Property(e => e.IdTarifaAcuerdo).HasColumnName("id_tarifa_acuerdo");
            entity.Property(e => e.Activa)
                .HasDefaultValue(true)
                .HasColumnName("activa");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.DiasDuracion).HasColumnName("dias_duracion");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.PrecioTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_total");
            entity.Property(e => e.PublicacionesIncluidas).HasColumnName("publicaciones_incluidas");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.TarifasAcuerdosComerciales)
                .HasForeignKey(d => d.IdStaff)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TarifasAc__id_st__753864A1");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.TarifasAcuerdosComerciales)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TarifasAc__id_ti__762C88DA");
        });

        modelBuilder.Entity<TarifasPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdTarifa).HasName("PK__TarifasP__747D0389B6AFA89E");

            entity.ToTable("TarifasPublicacion");

            entity.HasIndex(e => new { e.IdTipo, e.AnioTarifa, e.MesTarifa }, "uq_tarifa_tipo_mes_anio").IsUnique();

            entity.Property(e => e.IdTarifa).HasColumnName("id_tarifa");
            entity.Property(e => e.Activa)
                .HasDefaultValue(true)
                .HasColumnName("activa");
            entity.Property(e => e.AnioTarifa).HasColumnName("anio_tarifa");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.MesTarifa).HasColumnName("mes_tarifa");
            entity.Property(e => e.PrimeraPublicacionGratis)
                .HasDefaultValue(false)
                .HasColumnName("primera_publicacion_gratis");
            entity.Property(e => e.TarifaPorDia)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("tarifa_por_dia");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.TarifasPublicacions)
                .HasForeignKey(d => d.IdStaff)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TarifasPu__id_st__6BAEFA67");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.TarifasPublicacions)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TarifasPu__id_ti__6CA31EA0");
        });

        modelBuilder.Entity<TelefonosPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdTelefono).HasName("PK__Telefono__28CD6802D5B0C0FB");

            entity.ToTable("TelefonosPublicacion");

            entity.Property(e => e.IdTelefono).HasColumnName("id_telefono");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.Numero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.TipoTelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_telefono");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.TelefonosPublicacions)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Telefonos__id_pu__1352D76D");
        });

        modelBuilder.Entity<TiposFechaImportantes>(entity =>
        {
            entity.HasKey(e => e.IdTipoFecha).HasName("PK__TiposFec__3E1CD26E138F7824");

            entity.ToTable("TiposFechaImportante");

            entity.HasIndex(e => e.NombreTipo, "UQ__TiposFec__0C60C00D608F2458").IsUnique();

            entity.Property(e => e.IdTipoFecha).HasColumnName("id_tipo_fecha");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.NombreTipo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_tipo");
        });

        modelBuilder.Entity<TiposLinkMultimedia>(entity =>
        {
            entity.HasKey(e => e.IdTipo).HasName("PK__TiposLin__CF9010892A9DF516");

            entity.HasIndex(e => e.Nombre, "UQ__TiposLin__72AFBCC6939325CC").IsUnique();

            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TiposPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdTipo).HasName("PK__TiposPub__CF901089821292EB");

            entity.ToTable("TiposPublicacion");

            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.NombreTipo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_tipo");
        });

        modelBuilder.Entity<TransaccionesAcuerdo>(entity =>
        {
            entity.HasKey(e => e.IdTransaccionAcuerdo).HasName("PK__Transacc__34366D46EDA591D5");

            entity.ToTable("TransaccionesAcuerdo");

            entity.Property(e => e.IdTransaccionAcuerdo).HasColumnName("id_transaccion_acuerdo");
            entity.Property(e => e.EstadoPago)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("confirmado")
                .HasColumnName("estado_pago");
            entity.Property(e => e.FechaPago)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.IdAcuerdo).HasColumnName("id_acuerdo");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("metodo_pago");
            entity.Property(e => e.MontoPagado)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto_pagado");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.ReferenciaPago)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("referencia_pago");

            entity.HasOne(d => d.IdAcuerdoNavigation).WithMany(p => p.TransaccionesAcuerdos)
                .HasForeignKey(d => d.IdAcuerdo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transacci__id_ac__25DB9BFC");
        });

        modelBuilder.Entity<TransaccionesPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdTransaccion).HasName("PK__Transacc__1EDAC09984A57A3C");

            entity.ToTable("TransaccionesPublicacion");

            entity.Property(e => e.IdTransaccion).HasColumnName("id_transaccion");
            entity.Property(e => e.DiasContratados).HasColumnName("dias_contratados");
            entity.Property(e => e.EstadoTransaccion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("pendiente")
                .HasColumnName("estado_transaccion");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaPago)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("metodo_pago");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto_total");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.ReferenciaPago)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("referencia_pago");
            entity.Property(e => e.TipoTransaccion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipo_transaccion");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.TransaccionesPublicacions)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transacci__id_pu__0A338187");
        });

        modelBuilder.Entity<UbicacionesSistema>(entity =>
        {
            entity.HasKey(e => e.IdUbicacion).HasName("PK__Ubicacio__81BAA591560426B8");

            entity.ToTable("UbicacionesSistema");

            entity.Property(e => e.IdUbicacion).HasColumnName("id_ubicacion");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(9, 6)")
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasColumnType("decimal(9, 6)")
                .HasColumnName("longitud");
            entity.Property(e => e.Nivel1Region)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nivel_1_region");
            entity.Property(e => e.Nivel2Provincia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nivel_2_provincia");
            entity.Property(e => e.Nivel3Distrito)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nivel_3_distrito");
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pais");
            entity.Property(e => e.Referencia)
                .HasColumnType("text")
                .HasColumnName("referencia");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__4E3E04AD0BDEC892");

            entity.HasIndex(e => e.CorreoElectronico, "UQ__Usuarios__5B8A06826EF40CFD").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correo_electronico");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("activo")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.MetodoAutenticacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("metodo_autenticacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password_hash");
            entity.Property(e => e.TipoAcceso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_acceso");
        });

        modelBuilder.Entity<UsuariosRol>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioRol).HasName("PK__Usuarios__D1F881FE45C97446");

            entity.Property(e => e.IdUsuarioRol).HasColumnName("id_usuario_rol");
            entity.Property(e => e.FechaAsignacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_asignacion");
            entity.Property(e => e.IdDatosUsuario).HasColumnName("id_datos_usuario");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");

            entity.HasOne(d => d.IdDatosUsuarioNavigation).WithMany(p => p.UsuariosRoles)
                .HasForeignKey(d => d.IdDatosUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UsuariosR__id_da__5006DFF2");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.UsuariosRoles)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UsuariosR__id_ro__50FB042B");
        });

        modelBuilder.Entity<WhatsappsPublicacion>(entity =>
        {
            entity.HasKey(e => e.IdWhatsapp).HasName("PK__Whatsapp__5B608029CD1A3FCA");

            entity.ToTable("WhatsappsPublicacion");

            entity.Property(e => e.IdWhatsapp).HasColumnName("id_whatsapp");
            entity.Property(e => e.HorarioAtencion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("horario_atencion");
            entity.Property(e => e.IdPublicacion).HasColumnName("id_publicacion");
            entity.Property(e => e.MensajeAutomatico)
                .HasColumnType("text")
                .HasColumnName("mensaje_automatico");
            entity.Property(e => e.Numero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero");

            entity.HasOne(d => d.IdPublicacionNavigation).WithMany(p => p.WhatsappsPublicacions)
                .HasForeignKey(d => d.IdPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Whatsapps__id_pu__162F4418");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
