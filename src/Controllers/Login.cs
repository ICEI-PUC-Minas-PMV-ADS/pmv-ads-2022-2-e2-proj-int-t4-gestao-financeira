using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Gestão_Financeira.Controllers
{
    public class Login : Controller
    {
        public readonly IUsuarioRepositorio _usuarioRepositorio;
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UserModel usuario = _usuarioRepositorio.BuscaPorLogin(loginModel.Email);

                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            return RedirectToAction("Index", "HomeLogado");
                        }
                        
                    }

                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s)";
                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível realizar seu login, tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
