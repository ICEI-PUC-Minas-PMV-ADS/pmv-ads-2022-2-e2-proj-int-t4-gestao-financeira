using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Gestão_Financeira.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanejamentoCompraController : ControllerBase
    {
        private readonly IPlanejamentoCompraRepositorio _planejamentoCompraRepositorio;
        private readonly IItemRepositorio _itemRepositorio;

        public PlanejamentoCompraController(IPlanejamentoCompraRepositorio planejamentoCompraRepositorio, ItemRepositorio itemRepositorio)
        {
            _planejamentoCompraRepositorio = planejamentoCompraRepositorio;
            _itemRepositorio = itemRepositorio;
        }

        [HttpPost("planejamento-cadastrar")]
        public async Task<ActionResult> Cadastrar([FromBody] PlanejamentoCompraModel planejamentoCompra)
        {
            //_planejamentoCompraRepositorio.Cadastrar(planejamentoCompra);
            //_itemRepositorio.Cadastrar(planejamentoCompra.Item);

            return Created("Objeto planejamento Compra", planejamentoCompra);
        }

        [HttpPost("planejamento-atualizar")]
        public async Task<ActionResult> Atualizar([FromBody] PlanejamentoCompraModel planejamentoCompra)
        {
            //_planejamentoCompraRepositorio.Atualizar(planejamentoCompra);
            //_itemRepositorio.Atualizar(planejamentoCompra.Item);

            return Ok(planejamentoCompra);
        }

        [HttpGet("planejamento-consultar")]
        public async Task<ActionResult> Consultar([FromBody] int id)
        {
            var planejamento = _planejamentoCompraRepositorio.Consultar(id);
            var item = _itemRepositorio.Consultar(planejamento.ItemId);
            planejamento.Item = item;

            return Ok(planejamento);
        }

        [HttpDelete("planejamento-deletar")]
        public async Task<ActionResult> Deletar([FromBody] PlanejamentoCompraModel planejamentoCompra)
        {
            //_planejamentoCompraRepositorio.Deletar(planejamentoCompra);
            //_itemRepositorio.Deletar(planejamentoCompra.Item);

            return Ok("Planejamento Deletado");
        }
    }
}
