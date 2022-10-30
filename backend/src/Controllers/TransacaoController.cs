using Microsoft.AspNetCore.Mvc;
using Gestão_Financeira.Models;

namespace Gestão_Financeira.Controllers
{
    [ApiController]
    public class TransacaoController : ControllerBase;
    {
        [HttpPost("NovaTransacao")]
        public TransacaoModelResponse Saque([FromBody] TransacaoModelRequest transacao ) {

            
            

            var NovaTransacao = new TransacaoModelRequest 
            {
                Id: Guid.NewGuid().ToString(),
                valor: transacao.valor,
                tipoTransacao: transacao.tipoTransacao
                dataTransacao: new DateTime()
            }

            return NovaTransacao
            
        };
        [HttpGet("ConsultaSaldo")]
        public TransacaoModelResponse ConsultaSaldo([FromBody] TransacaoModelRequest transacao ) {
            
        };
    }
}
