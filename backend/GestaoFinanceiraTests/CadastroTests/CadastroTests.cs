using Gestão_Financeira.Controllers;
using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace GestaoFinanceiraTests.CadastroTests
{
    [TestClass]
    public class CadastroTests
    {
        private Mock<IUsuarioRepositorio> _usuarioRepositorioMock;
        private CadastroController _cadastroController;

        public CadastroTests()
        {
            _usuarioRepositorioMock = new Mock<IUsuarioRepositorio>();
            _cadastroController = new CadastroController(_usuarioRepositorioMock.Object);
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

            var result =_cadastroController.Criar(usuario);
            Assert.IsTrue(result != null);
        }
    }
}
