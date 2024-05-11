using Action_Result_Types.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Action_Result_Types.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View(); // returns a view to the client
        }

        [HttpPost]
        public IActionResult About()
        {
            return Content("This is a string"); // returns a string to the client
        }

        public IActionResult Contact() { 
            return NotFound();  // returns a custom status code to the client
        } 

        public IActionResult First() {
            return RedirectToAction("Second"); //redirecting the user to another URL
        }
        
        public IActionResult Second()
        {
            return Content("This is a second Action method"); 
        }


    }
}
