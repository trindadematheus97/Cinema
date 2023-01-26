using Cinema.Application.DTOs.InputModels;
using Cinema.Application.Services.Interfaces;
using Cinema.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cinema.Api.Controllers
{
    [Route("api/espectadores")]
    public class EspectadorController : Controller
    {
        private readonly IEspectadorService _espectadorService;

        public EspectadorController(IEspectadorService espectadorService)
        {
            _espectadorService = espectadorService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] EspectadorInputModel inputModel)
        {
            var espectadorAdicionado = _espectadorService.Create(inputModel);

            if (espectadorAdicionado == false)
                return BadRequest();

            return Ok(espectadorAdicionado);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_espectadorService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var espectador = _espectadorService.GetById(id);

            if (espectador == null)
                return NotFound();

            return Ok(espectador);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EspectadorInputModel inputModel)
        {
            var espectador = _espectadorService.GetById(id);

            if (espectador == null)
                return NotFound();

            if (_espectadorService.Update(inputModel, id) == true) return Ok();

            return BadRequest();
        }
        
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var espectador = _espectadorService.GetById(id);
            var espectadorDeletado = _espectadorService.Delete(id);

            if (espectadorDeletado == null)
                return NotFound();

            return Ok();
        }
    }
}
