using MediatR;

namespace upch.test.Aplication.Commands
{
    public record CommandEliminarAuto(int id) : IRequest<bool>;
}
