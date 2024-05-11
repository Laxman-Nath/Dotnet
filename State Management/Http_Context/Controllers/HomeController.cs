using Http_Context.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;

namespace Http_Context.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            HttpContext.Session.SetString("name", "laxman");

            return View();
        }

        public IActionResult Privacy()
        {
           string Name= HttpContext.Session.GetString("name").ToString();
            ViewBag.Name = Name;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
