using Microsoft.AspNetCore.Mvc;

namespace ControleVendas.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
