using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Gestão_Financeira.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaEmergencialController : ControllerBase
    {
        private readonly IReservaEmergencialRepositorio _reservaEmergencialRepositorio;
        private readonly ITransacaoRepositorio _transacaoRepositorio;
        private readonly TransacaoController _transacaoController;
        private static float _saldoReserva = 0;

        public ReservaEmergencialController(IReservaEmergencialRepositorio reservaEmergencialRepositorio, ITransacaoRepositorio transacaoRepositorio)
        {
            _reservaEmergencialRepositorio = reservaEmergencialRepositorio;
            _transacaoRepositorio = transacaoRepositorio;
            _transacaoController = new TransacaoController(_transacaoRepositorio);
        }

        [HttpPost("reserva-cadastrar")]
        public async Task<ActionResult> Cadastrar([FromBody] ReservaEmergencialModel reservaEmergencial)
        {
            //_reservaEmergencialRepositorio.Cadastrar(reservaEmergencial);

            return Created("Objeto reserva emergencial", reservaEmergencial);
        }

        [HttpPost("reserva-atualizar")]
        public async Task<ActionResult> Atualizar([FromBody] ReservaEmergencialModel reservaEmergencial)
        {
            //_reservaEmergencialRepositorio.Atualizar(reservaEmergencial);

            return Ok(reservaEmergencial);
        }

        [HttpPost("reserva-deposito")]
        public async Task<ActionResult> Depositar([FromBody] float valor)
        {
            if (valor <= 0)
                return BadRequest("O valor de deposito deve ser superior que zero.");

            _saldoReserva = _saldoReserva + valor;
            var transacao = new TransacaoModel { DataTransacao = DateTime.Now, TipoTransacao = "Deposito Reserva Emergencial", Valor = valor };
            var result = _transacaoController.Depositar(transacao);
            return Ok(_saldoReserva);
        }

        [HttpPost("reserva-saque")]
        public async Task<ActionResult> Sacar([FromBody] float valor)
        {
            if (valor > _saldoReserva)
                return BadRequest("O valor de saque não pode ser maior que o valor de saldo.");

            _saldoReserva = _saldoReserva - valor;

            var transacao = new TransacaoModel { DataTransacao = DateTime.Now, TipoTransacao = "Saque Reserva Emergencial", Valor = valor };
            var result = _transacaoController.Sacar(transacao);
            return Ok(_saldoReserva);
        }

        [HttpDelete("reserva-deletar")]
        public async Task<ActionResult> Deletar([FromBody] ReservaEmergencialModel reservaEmergencialModel)
        {
            //_reservaEmergencialRepositorio.Deletar(reservaEmergencialModel);

            return Ok("Planejamento Deletado");
        }
    }
}
