using MediatR;
using upch.test.Aplication.Commands;
using upch.test.Domain.Interfaces;

namespace upch.test.Aplication.Handlers
{
    public class ActualizarAutoHandler : IRequestHandler<CommandActualizarAuto, int>
    {
        private readonly IAutoRepositorio _autoRepositorio; //inyectamos repo sin acoplamiento
        public ActualizarAutoHandler(IAutoRepositorio autoRepositorio)
        {
            _autoRepositorio = autoRepositorio;
        }
        //recibe la peticion de mediator y permite desacoplar la dependencia
        public async Task<int> Handle(CommandActualizarAuto request, CancellationToken cancellationToken)
        {
            var autoDataNueva = request._auto;
            //validar que todos los datos esten completos...

            //validar que existe
            var oldAuto = await _autoRepositorio.ObtenerAuto(autoDataNueva.IdAuto);
            
            if (oldAuto == null)
                throw new Exception("No existe el auto");

            var cant = await _autoRepositorio.ActualizarAuto(autoDataNueva);

            return cant;
        }
    }
}
