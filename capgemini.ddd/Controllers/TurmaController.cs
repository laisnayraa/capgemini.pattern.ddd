using capgemini.ddd.Domain.Interfaces.Services;
using capgemini.ddd.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capgemini.ddd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaService _service;

        public TurmaController(ITurmaService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var value = _service.GetAll();

                return new ObjectResult(value) { StatusCode = StatusCodes.Status200OK };
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Turma value)
        {
            try
            {
                var retorno = _service.Add(value);

                return retorno ? new ObjectResult("Turma cadastrada com sucesso!") { StatusCode = StatusCodes.Status201Created }
                               : new ObjectResult("Não foi possível cadastrar a turma.") { StatusCode = StatusCodes.Status400BadRequest };
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
