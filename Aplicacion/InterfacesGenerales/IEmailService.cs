namespace BackendCConecta.Aplicacion.InterfacesGenerales
{
    public interface IEmailService
    {
        Task EnviarCorreoAsync(string destinatario, string asunto, string mensajeHtml);
    }
}
