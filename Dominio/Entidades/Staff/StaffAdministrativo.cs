using System;
using System.Collections.Generic;

using BackendCConecta.Dominio.Entidades.Campanias;
using BackendCConecta.Dominio.Entidades.Colaboradores;
using BackendCConecta.Dominio.Entidades.FechasImportantess;
using BackendCConecta.Dominio.Entidades.Paquetes;
using BackendCConecta.Dominio.Entidades.Historiales;
using BackendCConecta.Dominio.Entidades.Publicaciones;
using BackendCConecta.Dominio.Entidades.Transacciones;
using BackendCConecta.Dominio.Entidades.Representantes;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;
namespace BackendCConecta.Dominio.Entidades.Staff;


public partial class StaffAdministrativo
{
    public int IdStaff { get; set; }

    public int IdDatosUsuario { get; set; }

    public string? Nombres { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? Cargo { get; set; }

    public string? Area { get; set; }

    public bool? SuperAdmin { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<AccionesAdministrador> AccionesAdministradors { get; set; } = new List<AccionesAdministrador>();

    public virtual ICollection<Campania> Campania { get; set; } = new List<Campania>();

    public virtual ICollection<Colaborador> Colaboradores { get; set; } = new List<Colaborador>();

    public virtual ICollection<FechasImportantes> FechasImportantes { get; set; } = new List<FechasImportantes>();

    public virtual ICollection<HistorialEstadosPublicacion> HistorialEstadosPublicacions { get; set; } = new List<HistorialEstadosPublicacion>();

    public virtual ICollection<HistorialEstadosTransaccion> HistorialEstadosTransaccions { get; set; } = new List<HistorialEstadosTransaccion>();

    public virtual ICollection<HistorialModificacionesAcuerdo> HistorialModificacionesAcuerdos { get; set; } = new List<HistorialModificacionesAcuerdo>();

    public virtual ICollection<HistorialPostulacionesColaborador> HistorialPostulacionesColaboradors { get; set; } = new List<HistorialPostulacionesColaborador>();

    public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<MetaGlobalRespaldo> MetaGlobalRespaldos { get; set; } = new List<MetaGlobalRespaldo>();

    public virtual ICollection<PaquetesPromocional> PaquetesPromocionales { get; set; } = new List<PaquetesPromocional>();

    public virtual ICollection<ReconocimientosColaborador> ReconocimientosColaboradors { get; set; } = new List<ReconocimientosColaborador>();

    public virtual ICollection<TarifasAcuerdosComercial> TarifasAcuerdosComerciales { get; set; } = new List<TarifasAcuerdosComercial>();

    public virtual ICollection<TarifasPublicacion> TarifasPublicacions { get; set; } = new List<TarifasPublicacion>();
}
