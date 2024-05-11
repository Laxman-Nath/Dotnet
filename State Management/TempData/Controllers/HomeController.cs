using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TempData.Models;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            TempData["Id"] = 1;
            //var TempId = TempData["Id"];
            return View();
            //return RedirectToAction("About");
        }
        public IActionResult About()
        {
            //var empID = TempData["Id"];
            //TempData.Keep();
            return View();
            //return RedirectToAction("Contact");
        }
        public IActionResult Contact()
        {
            return View();
            //var empID = TempData["Id"];
            //return RedirectToAction("Us");
        }
        public IActionResult Us()
        {
            return View();
        }

        

        
    }
}
