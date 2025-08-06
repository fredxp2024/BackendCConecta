namespace BackendCConecta.Api.Seguridad
{

    public class JwtSettings
    {
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public string ClaveSecreta { get; set; } = string.Empty;
    }
}
