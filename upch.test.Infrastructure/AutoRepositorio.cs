using upch.test.Domain.Dtos;
using upch.test.Domain.Entities;
using upch.test.Domain.Interfaces;

namespace upch.test.Infrastructure
{
    public class AutoRepositorio :IAutoRepositorio //implementacion desacoplada del repositorio
    {
        public async ValueTask<Auto?> Crear(Auto? _nuevoAuto) 
        {
            return null;
        }
        public async ValueTask<Auto?> ObtenerAuto(int _id) 
        {
            return null;
        }
        public async ValueTask<int> ActualizarAuto(DTOAuto? _dto)
        {
            return 0;
        }
        public async ValueTask<bool> EliminarAuto(int Id)
        {
            return false;
        }
    }
}