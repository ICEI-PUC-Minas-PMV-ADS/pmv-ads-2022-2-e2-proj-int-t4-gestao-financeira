using Microsoft.AspNetCore.Mvc;

namespace Gestão_Financeira.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
