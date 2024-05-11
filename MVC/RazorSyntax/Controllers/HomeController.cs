using Microsoft.AspNetCore.Mvc;

namespace RazorSyntax.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
