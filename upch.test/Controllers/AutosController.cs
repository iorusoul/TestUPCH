using MediatR;
using Microsoft.AspNetCore.Mvc;
using upch.test.Aplication.Commands;
using upch.test.Aplication.Queries;
using upch.test.Domain.Dtos;
using upch.test.Domain.Entities;

namespace upch.test.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AutosController : ControllerBase
    {
        private readonly ILogger<AutosController> _logger;
        protected readonly IMediator _mediator;
        public AutosController(ILogger<AutosController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }


        [HttpGet(Name = "obtener")]
        public async Task<IActionResult> ObtenerAsync([FromQuery] int id)
        {
            var respuesta = new RespuestaJson();
            try
            {
                var command = new QueryObtenerAuto(id);
                var auto = await _mediator.Send(command);

                return respuesta.Ok(auto); //devuelve el auto encontrado...
            }
            catch (Exception e)
            {
                return await respuesta.Error(e, 500, "Error al consultar el id de auto");
            }
        }

        [HttpPost(Name = "crear")]
        public async ValueTask<IActionResult> Crear([FromBody] DTOAuto _dto)
        {
            //validar input...

            var respuesta = new RespuestaJson();
            try
            {
                var command = new CommandCrearAuto(_dto);
                var autoCreado = await _mediator.Send(command);
                
                return respuesta.Ok(autoCreado);
            }
            catch (Exception e)
            {
                return await respuesta.Error(e, 500, "Error al crear el auto");
            }
        }

        [HttpPut(Name = "actualizar")]
        public async Task<IActionResult> ActualizarAsync([FromBody] Auto _auto)
        {
            var respuesta = new RespuestaJson();
            try
            {
                var command = new CommandActualizarAuto(_auto);
                var registrosAfectados = await _mediator.Send(command);

                return respuesta.Ok(registrosAfectados);
            }
            catch (Exception e)
            {
                return await respuesta.Error(e, 500, "Error al actualizar");
            }
        }

        [HttpDelete( Name = "eliminar")]
        public async Task<IActionResult> EliminarAsync([FromQuery]int id)
        {
            var respuesta = new RespuestaJson();
            try
            {
                var command = new CommandEliminarAuto(id);
                var seElimino = await _mediator.Send(command);

                return respuesta.Ok(seElimino);
            }
            catch (Exception e)
            {
                return await respuesta.Error(e, 500, "Error al eliminar el auto");
            }
        }
    }
}