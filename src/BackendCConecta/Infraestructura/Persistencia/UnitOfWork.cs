
using global::BackendCConecta.Aplicacion.InterfacesGenerales;
using BackendCConecta.Infraestructura.Persistencia.Configuraciones;


namespace BackendCConecta.Infraestructura.Persistencia
{
    public class UnitOfWork : IUnitOfWork
        {
            private readonly AppDbContext _context;

            public UnitOfWork(AppDbContext context)
            {
                _context = context;
            }

            public async Task<int> GuardarCambiosAsync()
            {
                return await _context.SaveChangesAsync();
            }
        }
}
