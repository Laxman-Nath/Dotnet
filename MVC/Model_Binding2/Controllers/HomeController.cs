using Microsoft.AspNetCore.Mvc;
using Model_Binding2.Models;
using System.Diagnostics;

namespace Model_Binding2.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public String Index(WebUser web)
        {
            return "FirstName is:"+web.FirstName+" and last name is:"+web.LastName;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
