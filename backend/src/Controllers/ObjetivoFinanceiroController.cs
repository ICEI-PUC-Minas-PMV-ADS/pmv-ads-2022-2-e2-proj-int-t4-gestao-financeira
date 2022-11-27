using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Gestão_Financeira.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetivoFinanceiroController : ControllerBase
    {
        private readonly IObjetivoFinanceiroRepositorio _objetivoFinanceiroRepositorio;

        public ObjetivoFinanceiroController(IObjetivoFinanceiroRepositorio objetivoFinanceiroRepositorio)
        {
            _objetivoFinanceiroRepositorio = objetivoFinanceiroRepositorio;
        }

        [HttpPost("objetivo-cadastrar")]
        public async Task<ActionResult> Cadastrar([FromBody] ObjetivoFinanceiroModel objetivoFinanceiro)
        {
            _objetivoFinanceiroRepositorio.Cadastrar(objetivoFinanceiro);

            return Created("Objeto planejamento Compra", objetivoFinanceiro);
        }

        [HttpPost("objetivo-atualizar")]
        public async Task<ActionResult> Atualizar([FromBody] ObjetivoFinanceiroModel objetivoFinanceiro)
        {
            _objetivoFinanceiroRepositorio.Atualizar(objetivoFinanceiro);

            return Ok(objetivoFinanceiro);
        }

        [HttpGet("objetivo-consultar")]
        public async Task<ActionResult> Consultar([FromBody] int id)
        {
            var objetivo = _objetivoFinanceiroRepositorio.Consultar(id);

            return Ok(objetivo);
        }

        [HttpDelete("objetivo-deletar")]
        public async Task<ActionResult> Deletar([FromBody] ObjetivoFinanceiroModel objetivoFinanceiro)
        {
            _objetivoFinanceiroRepositorio.Deletar(objetivoFinanceiro);

            return Ok("Objetivo Deletado");
        }
    }
}
