using MediatR;
using upch.test.Domain.Dtos;
using upch.test.Domain.Entities;

namespace upch.test.Aplication.Commands
{
    public record CommandCrearAuto(DTOAuto _dtoAuto) : IRequest<Auto>;

}
