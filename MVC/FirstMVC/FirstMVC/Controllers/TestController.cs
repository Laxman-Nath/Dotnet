using Microsoft.AspNetCore.Mvc;

// Controllers in asp.net mvc
namespace FirstMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
