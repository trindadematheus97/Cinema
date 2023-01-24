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
            var espectadorAdicionado =  _espectadorService.CreateAsync(inputModel);

            if (espectadorAdicionado == false)
                return BadRequest();

            return Ok(espectadorAdicionado);
        }

        [HttpGet]
        public  IActionResult GetAll()
        {
            return Ok(_espectadorService.GetAll());
        }

        [HttpGet("{id}")]
        public  IActionResult GetById(int id)
        {
            var espectador = _espectadorService.GetById(id);

            if (espectador == null)
                return NotFound();

            return Ok(espectador);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Espectador inputModel, int id)
        {
            var espectador = _espectadorService.GetById(id);
            var espectadorAtualizado = _espectadorService.Update(inputModel, id);

            if (espectadorAtualizado == false)
                return BadRequest();

            return Ok();
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
