using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Gestão_Financeira.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesaVariavelController : ControllerBase
    {
        private readonly IDespesaVariavelRepositorio _despesaVariavelRepositorio;

        public DespesaVariavelController(IDespesaVariavelRepositorio despesaRepositorio)
        {
            _despesaVariavelRepositorio = despesaRepositorio;
        }

        [HttpPost("despesavariavel-cadastrar")]
        public async Task<ActionResult> Cadastrar([FromBody] DespesaVariavelModel despesa)
        {
            _despesaVariavelRepositorio.Cadastrar(despesa);

            return Created("Objeto reserva emergencial", despesa);
        }

        [HttpPost("despesavariavel-atualizar")]
        public async Task<ActionResult> Atualizar([FromBody] DespesaVariavelModel despesa)
        {
            _despesaVariavelRepositorio.Atualizar(despesa);

            return Ok(despesa);
        }

        [HttpGet("despesavariavel-consultar")]
        public async Task<ActionResult> Consultar(int id)
        {
            var despesaVariavel = _despesaVariavelRepositorio.Consultar(id);
            return Ok(despesaVariavel);
        }

        [HttpDelete("despesavariavel-deletar")]
        public async Task<ActionResult> Deletar([FromBody] int id)
        {
            _despesaVariavelRepositorio.Deletar(id);

            return Ok("Despesa Comum Deletada");
        }
    }
}
