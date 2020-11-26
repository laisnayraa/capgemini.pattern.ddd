using capgemini.ddd.Domain.Interfaces.Services;
using capgemini.ddd.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capgemini.ddd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _service;

        public AlunoController(IAlunoService service)
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
        public IActionResult Post([FromBody] Aluno value)
        {
            try
            {
                var retorno =_service.Add(value);

                return retorno ? new ObjectResult("Aluno cadastrado com sucesso!") { StatusCode = StatusCodes.Status201Created }
                               : new ObjectResult("Não foi possível cadastrar o aluno.") { StatusCode = StatusCodes.Status400BadRequest };
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
