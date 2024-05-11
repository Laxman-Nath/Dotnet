using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Temp_Data.Models;

namespace Temp_Data.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            ViewData["Var1"] = "message  from the viewdata";
            ViewBag.Var2 = " message  from the viewbag";
            TempData["Var3"] = "message  from the tempdata";
            //string[] games = { "Cricket", "Football", "Volleyball", "Hockey" };
            //TempData["Games"] = games;
            return RedirectToAction("Contact");
            return View();
        }

        public IActionResult About()
        {
            if (TempData["Var3"] != null) {
                TempData["Var3"].ToString();
            }
            /*TempData.Keep();*/
              return View();
        }

        public IActionResult Contact() {
            if (TempData["Var3"] != null)
            {
                TempData["Var3"].ToString();
            }

            return View();
        }
        
    }
}
