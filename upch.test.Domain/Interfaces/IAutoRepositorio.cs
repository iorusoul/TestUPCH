using upch.test.Domain.Dtos;
using upch.test.Domain.Entities;

namespace upch.test.Domain.Interfaces
{
    public interface IAutoRepositorio
    {
        public ValueTask<Auto?> Crear(Auto? _nuevoAuto);
        public ValueTask<Auto?> ObtenerAuto(int _id);
        public ValueTask<int> ActualizarAuto(DTOAuto _dto);
        public ValueTask<bool> EliminarAuto(int Id);
    }
}
