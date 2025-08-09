using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Handlers
{
 
    public class CrearDatosUsuarioHandler : IRequestHandler<CrearDatosUsuarioCommand, int>
    {
        private readonly IDatosUsuarioRepository _repository;

        public CrearDatosUsuarioHandler(IDatosUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CrearDatosUsuarioCommand request, CancellationToken cancellationToken)
        {
            var datos = new DatosUsuario
            {
                IdUsuario = request.IdUsuario,
                Celular = request.Celular,
                Direccion = request.Direccion,
                ImagenPerfil = request.ImagenPerfil,
                TipoUsuario = request.TipoUsuario,
                EstadoColaborador = request.EstadoColaborador,
                EstadoGeneral = request.EstadoGeneral,
                FechaRegistro = DateTime.UtcNow
            };

            await _repository.CrearAsync(datos, cancellationToken);
            return datos.IdDatosUsuario;
        }
    }
}