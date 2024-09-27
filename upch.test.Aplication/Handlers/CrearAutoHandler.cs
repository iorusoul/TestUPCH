using MediatR;
using upch.test.Aplication.Commands;
using upch.test.Domain.Entities;
using upch.test.Domain.Interfaces;

namespace upch.test.Aplication.Handlers
{
    public class CrearAutoHandler : IRequestHandler<CommandCrearAuto, Auto>
    {
        private readonly IAutoRepositorio _autoRepo;

        public CrearAutoHandler(IAutoRepositorio autoRepo)
        {
            _autoRepo = autoRepo;
        }

        //recibe la peticion de mediator y permite desacoplar la dependencia
        public async Task<Auto> Handle(CommandCrearAuto request, CancellationToken cancellationToken)
        {
            //validar

            // no asignamos id, se genera en BD para evitar posibles  colisiones si se ejecutan multiples instancias
            var autoNuevo = new Auto()
            {
                Anio = request._dtoAuto.Anio,
                CantidadPlazas = request._dtoAuto.CantidadPlazas,
                CantidadPuertas = request._dtoAuto.CantidadPuertas,
                Color = request._dtoAuto.Color,
                Kilometraje =  request._dtoAuto.Kilometraje,
                Marca = request._dtoAuto.Marca,
                Modelo = request._dtoAuto.Modelo,
                Peso = request._dtoAuto.Peso,
                TipoCajaCambios = request._dtoAuto.TipoCajaCambios,
                TipoCombustible = request._dtoAuto.TipoCombustible,
                TipoMotor = request._dtoAuto.TipoMotor
            };
            var creado = await _autoRepo.Crear(autoNuevo);

            return creado;
        }
    }
}
