using Microsoft.AspNetCore.Mvc;
using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;

namespace Gestão_Financeira.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private readonly ITransacaoRepositorio _transacaoRepositorio;
        private static float _saldo = 0;

        public TransacaoController(ITransacaoRepositorio transacaoRepositorio) {
            _transacaoRepositorio = transacaoRepositorio;
        }

        [HttpPost("transacao-deposito")]
        public async Task<ActionResult> Depositar([FromBody] TransacaoModel transacao)
        {
            if (string.IsNullOrEmpty(transacao.TipoTransacao) || transacao.TipoTransacao.Equals("string"))
            {
                transacao.TipoTransacao = "deposito";
            }

            if (transacao.Valor <= 0 && transacao.TipoTransacao.ToLower().Equals("deposito"))
                return BadRequest("O valor de deposito deve ser superior que zero.");

            if (transacao.TipoTransacao.ToLower().Equals("deposito"))
            {
                _saldo = _saldo + transacao.Valor;
            }

            //_transacaoRepositorio.Depositar(transacao);
            var historicoTransacao = new List<TransacaoModel>();
            historicoTransacao.Add(transacao);

            var transacaoResponse = new TransacaoModelResponse()
            {
                NovoSaldo = _saldo,
                HistoricoTransacao = historicoTransacao
            };

            return Created("Objeto transacao", transacaoResponse);
        }

        [HttpPost("transacao-saque")]
        public async Task<ActionResult> Sacar([FromBody]TransacaoModel transacao) {
            if (string.IsNullOrEmpty(transacao.TipoTransacao) || transacao.TipoTransacao.Equals("string"))
            {
                transacao.TipoTransacao = "saque";
            }

            if (transacao.Valor > _saldo && transacao.TipoTransacao.ToLower().Equals("saque"))
                return BadRequest("O valor de saque não pode ser maior que o valor de saldo.");

            if (transacao.TipoTransacao.ToLower().Equals("saque")){
                _saldo = _saldo - transacao.Valor;
            }

            //_transacaoRepositorio.Sacar(transacao);
            var historicoTransacao = new List<TransacaoModel>();
            historicoTransacao.Add(transacao);

            var transacaoResponse = new TransacaoModelResponse()
            {
                NovoSaldo = _saldo,
                HistoricoTransacao = historicoTransacao
            };

            return Created("Objeto transacao", transacaoResponse);
        }

        [HttpGet("transacao-saldo")]
        public async Task<ActionResult> ConsultarSaldo() {
            return Ok(_saldo);
        }
    }
}
