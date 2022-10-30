using Microsoft.AspNetCore.Mvc;

namespace Gestão_Financeira.Controllers
{
    public class ComoFunciona : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
