using MediatR;
using upch.test.Domain.Entities;

namespace upch.test.Aplication.Commands
{
    public record CommandActualizarAuto(Auto _auto) : IRequest<int>;
    
}
