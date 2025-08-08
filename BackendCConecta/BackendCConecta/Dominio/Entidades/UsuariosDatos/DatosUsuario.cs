using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Staff;
using BackendCConecta.Dominio.Entidades.Acuerdos;
using BackendCConecta.Dominio.Entidades.Colaboradores;
using BackendCConecta.Dominio.Entidades.Intereses;
using BackendCConecta.Dominio.Entidades.Publicaciones;
using BackendCConecta.Dominio.Entidades.Roles;
using BackendCConecta.Dominio.Entidades.Paquetes;
using BackendCConecta.Dominio.Entidades.Usuarios;
using BackendCConecta.Dominio.Entidades.Empresas;
using BackendCConecta.Dominio.Entidades.Personas;

namespace BackendCConecta.Dominio.Entidades.UsuariosDatos;

public partial class DatosUsuario
{
    public int IdDatosUsuario { get; set; }

    public int IdUsuario { get; set; }

    public string? Celular { get; set; }

    public string? Direccion { get; set; }

    public string? ImagenPerfil { get; set; }

    public string TipoUsuario { get; set; } = null!;

    public string? EstadoColaborador { get; set; }

    public string? EstadoGeneral { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<AccionesAdministrador> AccionesAdministradors { get; set; } = new List<AccionesAdministrador>();

    public virtual ICollection<AcuerdosComercial> AcuerdosComerciales { get; set; } = new List<AcuerdosComercial>();

    public virtual ICollection<AsignacionesPaqueteUsuario> AsignacionesPaqueteUsuarios { get; set; } = new List<AsignacionesPaqueteUsuario>();

    public virtual Colaborador? Colaborador { get; set; }

    public virtual DatosEmpresa? DatosEmpresa { get; set; }

    public virtual DatosPersona? DatosPersona { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<InteresesUsuario> InteresesUsuarios { get; set; } = new List<InteresesUsuario>();

    public virtual ICollection<PostulacionesColaborador> PostulacionesColaboradors { get; set; } = new List<PostulacionesColaborador>();

    public virtual ICollection<Publicacion> Publicaciones { get; set; } = new List<Publicacion>();

    public virtual StaffAdministrativo? StaffAdministrativo { get; set; }

    public virtual ICollection<UsuarioRol> UsuariosRoles { get; set; } = new List<UsuarioRol>();
}
