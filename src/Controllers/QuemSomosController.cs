using Microsoft.AspNetCore.Mvc;

namespace Gestão_Financeira.Controllers
{
    public class QuemSomosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
