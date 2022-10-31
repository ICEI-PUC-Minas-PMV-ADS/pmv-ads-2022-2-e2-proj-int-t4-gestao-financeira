using Gestão_Financeira.Controllers;
using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GestaoFinanceiraTests.TransacaoTests
{
    [TestClass]
    public class TransacaoTests
    {
        private Mock<ITransacaoRepositorio> _transacaoRepositorioMock;
        private CadastroController _cadastroController;

        public TransacaoTests()
        {
            _transacaoRepositorioMock = new Mock<ITransacaoRepositorio>();
            _cadastroController = new TransacaoController(_transacaoRepositorioMock.Object);
        }

        [TestMethod]
        public void CadastraUsuarioComSucesso()
        {
            var usuario = new UserModel
            {
                Id = 1,
                Nome = "Pedro Freitas",
                Apelido = "Pedrao",
                Senha = "Psw2325@",
                Email = "pedrocabrito@gmail.com"
            };

            var result = _cadastroController.Criar(usuario);
            Assert.IsTrue(result != null);
        }
    }
}
