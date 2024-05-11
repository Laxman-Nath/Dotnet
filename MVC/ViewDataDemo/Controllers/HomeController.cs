using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewDataDemo.Models;

namespace ViewDataDemo.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            ViewData["Message"] = "This is message from view data";
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();
            ViewData["Fruits"] = new string[] { "Apple", "Banana", "Orange", "Grapes" };
            ViewData["Sports"] = new List<string>() { "Cricket", "Football", "Hockey", "Volleyball" };

            Employee laxman=new Employee();
            laxman.Name = "rohit";
            laxman.Email = "abc@gmail.com";
            laxman.Id = 1;

            ViewData["Employee"] = laxman;
            return View();
        }



        
    }
}
