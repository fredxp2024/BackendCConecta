namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.DTOs
{
    public class DatosEmpresaDto
    {
        // Datos de la empresa
        public int IdDatosUsuario { get; set; }
        public string RazonSocial { get; set; } = string.Empty;
        public string Ruc { get; set; } = string.Empty;
        public string? PaginaWeb { get; set; }

        // Datos de la persona vinculada (opcional)
        public string? Nombres { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Dni { get; set; }
    }
}
