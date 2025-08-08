using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Multimedia;

public partial class WhatsappsPublicacion
{
    public int IdWhatsapp { get; set; }

    public int IdPublicacion { get; set; }

    public string? Numero { get; set; }

    public string? MensajeAutomatico { get; set; }

    public string? HorarioAtencion { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
