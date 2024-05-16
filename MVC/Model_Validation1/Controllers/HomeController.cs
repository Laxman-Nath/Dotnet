using Microsoft.AspNetCore.Mvc;
using Model_Validation1.Models;
using System.Diagnostics;

namespace Model_Validation1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult  Index(Student s)
        {
            return View(s);
            //if (ModelState.IsValid)
            //{
            //    return "Name is :" + s.Name;
            //}
            //else
            //{
            //    return "Valiataion error";
            //}
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
