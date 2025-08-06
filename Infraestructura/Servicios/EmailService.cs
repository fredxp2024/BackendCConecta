using System.Net.Mail;
using System.Net;
using BackendCConecta.Aplicacion.InterfacesGenerales;


namespace BackendCConecta.Infraestructura.Servicios
{

public class EmailService : IEmailService
{
    private readonly IConfiguration _config;

    public EmailService(IConfiguration config)
    {
        _config = config;
    }

    public async Task EnviarCorreoAsync(string destinatario, string asunto, string mensajeHtml)
    {
        var remitente = _config["EmailSettings:Remitente"];
        var smtpHost = _config["EmailSettings:SmtpHost"];
        var smtpPort = int.Parse(_config["EmailSettings:SmtpPort"] ?? "587");
        var smtpUsuario = _config["EmailSettings:Usuario"];
        var smtpClave = _config["EmailSettings:Clave"];

        using var mensaje = new MailMessage();
        mensaje.From = new MailAddress(remitente);
        mensaje.To.Add(destinatario);
        mensaje.Subject = asunto;
        mensaje.Body = mensajeHtml;
        mensaje.IsBodyHtml = true;

        using var smtp = new SmtpClient(smtpHost, smtpPort)
        {
            Credentials = new NetworkCredential(smtpUsuario, smtpClave),
            EnableSsl = true
        };

        await smtp.SendMailAsync(mensaje);
    }

    }
}