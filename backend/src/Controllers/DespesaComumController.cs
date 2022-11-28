using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Gestão_Financeira.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesaComumController : ControllerBase
    {
        private readonly IDespesaComumRepositorio _despesaComumRepositorio;

        public DespesaComumController(IDespesaComumRepositorio despesaRepositorio)
        {
            _despesaComumRepositorio = despesaRepositorio;
        }

        [HttpPost("despesacomum-cadastrar")]
        public async Task<ActionResult> Cadastrar([FromBody] DespesaComumModel despesa)
        {
            _despesaComumRepositorio.Cadastrar(despesa);

            return Created("Objeto reserva emergencial", despesa);
        }

        [HttpPost("despesacomum-atualizar")]
        public async Task<ActionResult> Atualizar([FromBody] DespesaComumModel despesa)
        {
            _despesaComumRepositorio.Atualizar(despesa);

            return Ok(despesa);
        }

        [HttpGet("despesacomum-consultar")]
        public async Task<ActionResult> Consultar(int id)
        {
            var despesaComum = _despesaComumRepositorio.Consultar(id);
            return Ok(despesaComum);
        }

        [HttpDelete("despesacomum-deletar")]
        public async Task<ActionResult> Deletar([FromBody] int id)
        {
            _despesaComumRepositorio.Deletar(id);

            return Ok("Despesa Comum Deletada");
        }
    }
}
