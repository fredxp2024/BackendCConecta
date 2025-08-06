using System;
using System.Collections.Generic;

namespace BackendCConecta.Dominio.Entidades.FechasImportantess;

public partial class TiposFechaImportantes
{
    public int IdTipoFecha { get; set; }

    public string NombreTipo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<FechasImportantes> FechasImportantes { get; set; } = new List<FechasImportantes>();
}
