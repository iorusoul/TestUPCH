using MediatR;
using upch.test.Domain.Entities;

namespace upch.test.Aplication.Queries
{
    public record QueryObtenerAuto(int id) : IRequest<Auto>;
}
