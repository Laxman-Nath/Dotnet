using Form_TagHelpers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Form_TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
