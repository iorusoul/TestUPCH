using MediatR;
using upch.test.Aplication.Queries;
using upch.test.Domain.Entities;
using upch.test.Domain.Interfaces;

namespace upch.test.Aplication.Handlers
{
    public class ObtenerAutoHandler : IRequestHandler<QueryObtenerAuto, Auto>
    {
        private readonly IAutoRepositorio _autorepo;

        public ObtenerAutoHandler(IAutoRepositorio autorepo)
        {
            _autorepo = autorepo;
        }

        //recibe la peticion de mediator y permite desacoplar la dependencia
        async Task<Auto> IRequestHandler<QueryObtenerAuto, Auto>.Handle(QueryObtenerAuto request, CancellationToken cancellationToken)
        {
            //validar...

            var auto = await _autorepo.ObtenerAuto(request.id);

            if (auto == null)
                throw new Exception("No existe el auto buscado.");

            return auto;
        }
    }
}
