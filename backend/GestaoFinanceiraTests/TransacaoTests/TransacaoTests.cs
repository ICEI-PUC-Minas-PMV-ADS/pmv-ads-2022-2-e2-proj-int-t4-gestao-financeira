using Gestão_Financeira.Controllers;
using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GestaoFinanceiraTests.TransacaoTests
{
    [TestClass]
    public class TransacaoTests
    {
        private Mock<ITransacaoRepositorio> _transacaoRepositorioMock;
        private TransacaoController _transacaoController;

        public TransacaoTests()
        {
            _transacaoRepositorioMock = new Mock<ITransacaoRepositorio>();
            _transacaoController = new TransacaoController(_transacaoRepositorioMock.Object);
        }

        [TestMethod]
        public void TransacaoDeDepositoComSucesso()
        {
            var transacao = new TransacaoModel
            {
                Id = 1,
                Valor = 100
            };

            var result = _transacaoController.Depositar(transacao).Result as CreatedResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.StatusCode, StatusCodes.Status201Created);
        }

        [TestMethod]
        public void TransacaoDeSaqueComSucesso()
        {
            var transacao = new TransacaoModel
            {
                Id = 1,
                Valor = 100
            };

            _transacaoController.Depositar(transacao);
            transacao.Valor = 50;
            
            var result = _transacaoController.Sacar(transacao).Result as CreatedResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(result.StatusCode, StatusCodes.Status201Created);
        }

        [TestMethod]
        public void TransacaoConsultaSaldoComSucesso()
        {
            var transacao = new TransacaoModel
            {
                Id = 1,
                Valor = 100
            };

            _transacaoController.Depositar(transacao);

            var result = _transacaoController.ConsultarSaldo().Result as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
            Assert.AreEqual(result.Value, transacao.Valor);
        }
    }
}
