using Microsoft.AspNetCore.Mvc;
using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;

namespace Gestão_Financeira.Controllers
{
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private readonly TransacaoRepositorio _transacaoRepositorio;
        private static float _saldo = 0; //Remover futuramente, o correto é fazermos a manutenção do saldo na entidade SaldoConta

        public TransacaoController(TransacaoRepositorio transacaoRepositorio){
            _transacaoRepositorio = transacaoRepositorio;
        }

        [HttpPost("transacao-saque")]
        public async Task<ActionResult> Sacar([FromBody]TransacaoModel transacao) {

            if(transacao.Valor > _saldo)
                return BadRequest("O valor de saque não pode ser maior que o valor de saldo.");

            _transacaoRepositorio.Sacar(transacao);
            _saldo = _saldo - transacao.Valor;

            var historicoTransacao = new List<TransacaoModel>();
            historicoTransacao.Add(transacao);

            var transacaoResponse = new TransacaoModelResponse()
            {
                NovoSaldo = _saldo,
                HistoricoTransacao = historicoTransacao
            };

            return Created("Objeto transacao", transacaoResponse);
        }

        [HttpPost("transacao-deposito")]
        public async Task<ActionResult> Depositar([FromBody] TransacaoModel transacao)
        {

            if (transacao.Valor <= 0)
                return BadRequest("O valor de deposito deve ser superior que zero.");

            _transacaoRepositorio.Depositar(transacao);
            _saldo = _saldo + transacao.Valor;

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
