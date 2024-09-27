using MediatR;
using upch.test.Aplication.Commands;
using upch.test.Domain.Interfaces;

namespace upch.test.Aplication.Handlers
{
    public class EliminarAutoHandler : IRequestHandler<CommandEliminarAuto, bool>
    {
        private readonly IAutoRepositorio _autoRepo;

        public EliminarAutoHandler(IAutoRepositorio autoRepo)
        {
            _autoRepo = autoRepo;
        }

        public async Task<bool> Handle(CommandEliminarAuto request, CancellationToken cancellationToken)
        {
            //validar query
            var auto = await _autoRepo.ObtenerAuto(request.id);
            if (auto == null)
                throw new Exception("No existe el auto");

            var eliminado = await _autoRepo.EliminarAuto(request.id);

            return eliminado;
        }
    }
}
