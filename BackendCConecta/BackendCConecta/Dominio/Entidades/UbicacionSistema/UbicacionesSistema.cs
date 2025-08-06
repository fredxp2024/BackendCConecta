using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Campanias;
using BackendCConecta.Dominio.Entidades.FechasImportantess;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.UbicacionSistema;

public partial class UbicacionesSistema
{
    public int IdUbicacion { get; set; }

    public string? Pais { get; set; }

    public string? Nivel1Region { get; set; }

    public string? Nivel2Provincia { get; set; }

    public string? Nivel3Distrito { get; set; }

    public string? Referencia { get; set; }

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }

    public virtual ICollection<Campania> Campania { get; set; } = new List<Campania>();

    public virtual ICollection<FechasImportantes> FechasImportantes { get; set; } = new List<FechasImportantes>();

    public virtual ICollection<LugaresReferencia> LugaresReferencia { get; set; } = new List<LugaresReferencia>();

    public virtual ICollection<Publicacion> Publicaciones { get; set; } = new List<Publicacion>();
}
