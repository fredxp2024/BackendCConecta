namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs
{
    public class DatosEmpresaDto
    {
        public int IdDatosUsuario { get; set; }
        public string RazonSocial { get; set; } = string.Empty;
        public string? Ruc { get; set; }
        public string? PaginaWeb { get; set; }
    }
}
