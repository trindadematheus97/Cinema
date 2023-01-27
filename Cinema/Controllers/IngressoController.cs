using Cinema.Application.DTOs.InputModels;
using Cinema.Application.Services.Implementations;
using Cinema.Application.Services.Interfaces;
using Cinema.Core.DTOs.InputModels;
using Cinema.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Cinema.Api.Controllers
{
    [Route("api/espectadores/ingressos")]
    public class IngressoController : Controller
    {
        private readonly IIngressoService _ingressoService;

        public IngressoController(IIngressoService ingressoService)
        {
            _ingressoService = ingressoService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] List<IngressoInputModel> inputmodel)
        {
            var ingresso = _ingressoService.BuyTickets(inputmodel);

            if (ingresso > 0) return Ok(ingresso);

            return NotFound(ingresso);

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ingressoService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var ingresso = _ingressoService.GetById(id);

            if (ingresso == null) return NotFound();

            return Ok(ingresso);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] IngressoInputModel inputModel)
        {
            var ingresso = _ingressoService.GetById(id);

            if (ingresso == null) return NotFound();

            if (_ingressoService.Update(inputModel, id) == true) return Ok();

            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var ingresso = _ingressoService.GetById(id);

            if (ingresso == null) return NotFound();

            var ingressoDeletado = _ingressoService.Delete(id);

            if (ingressoDeletado == true)
                return Ok();

            return BadRequest();
        }
    }
}
