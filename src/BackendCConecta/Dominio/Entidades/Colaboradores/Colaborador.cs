using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.FechasImportantess;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;
using BackendCConecta.Dominio.Entidades.Staff;

namespace BackendCConecta.Dominio.Entidades.Colaboradores;

public partial class Colaborador
{
    public int IdColaborador { get; set; }

    public int IdDatosUsuario { get; set; }

    public string EstadoColaborador { get; set; } = null!;

    public string MetodoIngreso { get; set; } = null!;

    public int? IdStaffAprobador { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public string? Observaciones { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<FechasImportantes> FechasImportantes { get; set; } = new List<FechasImportantes>();

    public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;

    public virtual StaffAdministrativo? IdStaffAprobadorNavigation { get; set; }

    public virtual ICollection<ParticipacionColaborador> ParticipacionColaboradors { get; set; } = new List<ParticipacionColaborador>();

    public virtual ICollection<PerfilColaboradorExtendido> PerfilColaboradorExtendidos { get; set; } = new List<PerfilColaboradorExtendido>();

    public virtual ICollection<ReconocimientosColaborador> ReconocimientosColaboradors { get; set; } = new List<ReconocimientosColaborador>();
}
