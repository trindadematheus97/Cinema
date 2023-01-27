using Cinema.Application.DTOs.InputModels;
using Cinema.Application.Services.Implementations;
using Cinema.Application.Services.Interfaces;
using Cinema.Core.DTOs.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Api.Controllers
{
    [Route("api/filmes")]
    public class FilmeController : Controller
    {
        private readonly IFilmeService _filmeService;

        public FilmeController(IFilmeService filmeService)
        {
            _filmeService = filmeService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] FilmeInputModel inputModel)
        {
            var filmeAdicionado = _filmeService.FilmRegistration(inputModel);

            if (filmeAdicionado == false)
                return BadRequest();

            return Ok(filmeAdicionado);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_filmeService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var filme = _filmeService.GetById(id);

            if (filme == null)
                return NotFound();

            return Ok(filme);

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] FilmeInputModel inputModel)
        {
            var filme = _filmeService.GetById(id);

            if (filme == null) return NotFound();

            if (_filmeService.Update(inputModel, id) == true) return Ok();

            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var filme = _filmeService.GetById(id);
            var filmeDeletado = _filmeService.Delete(id);

            if (filmeDeletado == null)
                return NotFound();

            return Ok();
        }
    }
}
