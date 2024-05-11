using Microsoft.AspNetCore.Mvc;
using Model_Binding.Models;
using System.Diagnostics;

namespace Model_Binding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public String Index(Employee e)
        {
            return "Name is:" + e.Name+" Gender is:"+e.Gender+" Age is:"+e.Age+" Designation is:"+e.Designation+" Descriptio is:"+e.Description+" Married :"+e.Married;
        }
        public string Details(int id,string name) {
            return "My id is:" + id + " and My name is :" + name;
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
