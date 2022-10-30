using Microsoft.AspNetCore.Mvc;

namespace Gestão_Financeira.Controllers
{
    public class HomeLogadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
