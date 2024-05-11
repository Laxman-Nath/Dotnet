using Difference_ViewData_ViewBag.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Difference_ViewData_ViewBag.Models;

namespace Difference_ViewData_ViewBag.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            ViewData["Message1"] = "This message is from the viewdata";
            ViewBag.Message2= "This message is from the viewBag";
            ViewData["CurrentDate1"]=DateTime.Now.ToString();
            ViewBag.CurrentDate2= DateTime.Now.ToString();
            string[] games = { "Hockey", "Cricket", "Volleyball", "Football" };
            ViewBag.Games = games;
            ViewData["Sports"] = games;

            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.Name = "Laxman";
            emp1.Address = "mnr";
            ViewBag.Employee2 = emp1;
            ViewData["Employee1"] = emp1;
            return View();
        }

       
    }
}
