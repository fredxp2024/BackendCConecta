
using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Paquetes;
using BackendCConecta.Dominio.Entidades.Avisos;
using BackendCConecta.Dominio.Entidades.Eventos;
using BackendCConecta.Dominio.Entidades.Negocios;
using BackendCConecta.Dominio.Entidades.Representantes;
using BackendCConecta.Dominio.Entidades.Historiales;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;
using BackendCConecta.Dominio.Entidades.UbicacionSistema;
using BackendCConecta.Dominio.Entidades.Multimedia;
using BackendCConecta.Dominio.Entidades.Transacciones;
using BackendCConecta.Dominio.Entidades.Colaboradores;
using BackendCConecta.Dominio.Entidades.Intereses;
using BackendCConecta.Dominio.Entidades.Contactos;

namespace BackendCConecta.Dominio.Entidades.Publicaciones;

public partial class Publicacion
{
    public int IdPublicacion { get; set; }

    public int IdDatosUsuario { get; set; }

    public int IdTipo { get; set; }

    public int? IdSubcategoria { get; set; }

    public int? IdUbicacion { get; set; }

    public string? EstadoPublicacion { get; set; }

    public DateTime? FechaCambioEstado { get; set; }

    public virtual ICollection<ArchivosAdjuntosPublicacion> ArchivosAdjuntosPublicacions { get; set; } = new List<ArchivosAdjuntosPublicacion>();

    public virtual Aviso? Aviso { get; set; }

    public virtual ICollection<ContactosAdicionalesPublicacion> ContactosAdicionalesPublicacions { get; set; } = new List<ContactosAdicionalesPublicacion>();

    public virtual ICollection<DetallePublicacionPaquete> DetallePublicacionPaquetes { get; set; } = new List<DetallePublicacionPaquete>();

    public virtual DetallesPublicacion? DetallesPublicacion { get; set; }

    public virtual Evento? Evento { get; set; }

    public virtual ICollection<HistorialEstadosPublicacion> HistorialEstadosPublicacions { get; set; } = new List<HistorialEstadosPublicacion>();

    public virtual ICollection<HistorialPublicacionFecha> HistorialPublicacionFechas { get; set; } = new List<HistorialPublicacionFecha>();

    public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;

    public virtual SubcategoriasPublicacion? IdSubcategoriaNavigation { get; set; }

    public virtual TiposPublicacion IdTipoNavigation { get; set; } = null!;

    public virtual UbicacionSistema? IdUbicacionNavigation { get; set; }

    public virtual ICollection<InteresesPublicacion> InteresesPublicacions { get; set; } = new List<InteresesPublicacion>();

    public virtual ICollection<LinksMultimedia> LinksMultimedia { get; set; } = new List<LinksMultimedia>();

    public virtual ICollection<MultimediaPublicacion> MultimediaPublicacions { get; set; } = new List<MultimediaPublicacion>();

    public virtual Negocio? Negocio { get; set; }

    public virtual ICollection<ParticipacionColaborador> ParticipacionColaboradors { get; set; } = new List<ParticipacionColaborador>();

    public virtual ICollection<PreciosPublicacion> PreciosPublicacions { get; set; } = new List<PreciosPublicacion>();

    public virtual ICollection<PublicacionesEnAcuerdo> PublicacionesEnAcuerdos { get; set; } = new List<PublicacionesEnAcuerdo>();

    public virtual ICollection<RedesSocialesPublicacion> RedesSocialesPublicacions { get; set; } = new List<RedesSocialesPublicacion>();

    public virtual Representante? Representante { get; set; }

    public virtual ICollection<TelefonosPublicacion> TelefonosPublicacions { get; set; } = new List<TelefonosPublicacion>();

    public virtual ICollection<TransaccionesPublicacion> TransaccionesPublicacions { get; set; } = new List<TransaccionesPublicacion>();

    public virtual ICollection<WhatsappsPublicacion> WhatsappsPublicacions { get; set; } = new List<WhatsappsPublicacion>();

    public virtual ICollection<LugaresReferencia> Lugares { get; set; } = new List<LugaresReferencia>();
}
