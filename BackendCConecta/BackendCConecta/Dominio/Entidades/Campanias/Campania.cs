using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Staff;
using BackendCConecta.Dominio.Entidades.UbicacionSistema;
using BackendCConecta.Dominio.Entidades.Representantes;
using BackendCConecta.Dominio.Entidades.CampaniasPromocionales;

namespace BackendCConecta.Dominio.Entidades.Campanias;

public partial class Campania
{
    public int IdCampania { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string TipoCampania { get; set; } = null!;

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public string? Estado { get; set; }

    public int? IdUbicacion { get; set; }

    public int IdStaff { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual CampaniasElectoral? CampaniasElectorale { get; set; }

    public virtual CampaniasPromocional? CampaniasPromocionale { get; set; }

    public virtual StaffAdministrativo IdStaffNavigation { get; set; } = null!;

    public virtual UbicacionSistema? IdUbicacionNavigation { get; set; }

    public virtual ICollection<MetaGlobalRespaldo> MetaGlobalRespaldos { get; set; } = new List<MetaGlobalRespaldo>();

    public virtual ICollection<RepresentantesCampania> RepresentantesCampania { get; set; } = new List<RepresentantesCampania>();
}
