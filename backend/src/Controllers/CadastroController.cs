using Gestão_Financeira.Models;
using Gestão_Financeira.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Gestão_Financeira.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public CadastroController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar(UserModel usuario)  
        {
            _usuarioRepositorio.Adicionar(usuario);
            return RedirectToAction("Index");
        }
    }
}
