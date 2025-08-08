using System;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.DTOs
{
    public class EmpresasDto
    {
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Estado { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
