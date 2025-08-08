namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs;

public class CrearDatosEmpresaDto
{
    public int IdDatosUsuario { get; set; }
    public string RazonSocial { get; set; } = null!;
    public string? Ruc { get; set; }
    public string? PaginaWeb { get; set; }
}
