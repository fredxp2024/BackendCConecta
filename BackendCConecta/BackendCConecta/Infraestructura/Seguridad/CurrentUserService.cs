using System.Security.Claims;
using BackendCConecta.Aplicacion.InterfacesGenerales;
using Microsoft.AspNetCore.Http;

namespace BackendCConecta.Infraestructura.Seguridad
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _http;

        public CurrentUserService(IHttpContextAccessor http) => _http = http;

        private ClaimsPrincipal? Principal => _http.HttpContext?.User;

        public string? UserId => Principal?.FindFirstValue(ClaimTypes.NameIdentifier)
                              ?? Principal?.FindFirstValue("sub");

        public string? Email => Principal?.FindFirstValue(ClaimTypes.Email);

        public bool IsAuthenticated => Principal?.Identity?.IsAuthenticated == true;

        public bool IsInRole(string role) => Principal?.IsInRole(role) == true;

        public IEnumerable<Claim> Claims => Principal?.Claims ?? Enumerable.Empty<Claim>();
    }
}
