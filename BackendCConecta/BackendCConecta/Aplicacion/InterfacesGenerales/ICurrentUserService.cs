namespace BackendCConecta.Aplicacion.InterfacesGenerales
{
    public interface ICurrentUserService
    {
        string? UserId { get; }
        string? Email { get; }
        bool IsAuthenticated { get; }
        bool IsInRole(string role);
        IEnumerable<System.Security.Claims.Claim> Claims { get; }
    }
}
