using Microsoft.AspNetCore.Mvc;
using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;

namespace Gestão_Financeira.Controllers
{
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private readonly TransacaoRepositorio _transacaoRepositorio;

        public TransacaoController(TransacaoRepositorio transacaoRepositorio){
            _transacaoRepositorio = transacaoRepositorio;
        }

        [HttpPost("NovaTransacao")]
        public TransacaoModelResponse Saque([FromBody] TransacaoModel transacao ) {

            throw new NotImplementedException();
        }

        [HttpGet("ConsultaSaldo")]
        public TransacaoModelResponse ConsultaSaldo(int id) {
            throw new NotImplementedException();
        }
    }
}
