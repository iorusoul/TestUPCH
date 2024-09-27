using Microsoft.AspNetCore.Mvc;
using upch.test.Domain.Dtos;
using upch.test.Domain.Entities;

namespace upch.test.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AutosController : ControllerBase
    {
        private readonly ILogger<AutosController> _logger;

        public AutosController(ILogger<AutosController> logger)
        {
            _logger = logger;
        }


        [HttpGet("{id}", Name = "Obtener")]
        public IEnumerable<AutosController> Obtener([FromQuery] int id)
        {
            return null;
        }

        [HttpPost(Name = "Crear")]
        public IEnumerable<AutosController> Crear([FromBody] DTOAuto _dto)
        {
            return null;
        }

        [HttpPut(Name = "update")]
        public IEnumerable<AutosController> Update([FromBody] Auto _auto)
        {
            return null;
        }

        [HttpPut("{id}", Name = "Delete")]
        public IEnumerable<AutosController> Delete()
        {
            return null;
        }
    }
}