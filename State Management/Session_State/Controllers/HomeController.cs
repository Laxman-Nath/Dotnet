using Microsoft.AspNetCore.Mvc;
using Session_State.Models;
using System.Diagnostics;

namespace Session_State.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IHttpContextAccessor context;
        //public HomeController(IHttpContextAccessor context)
        //{
        //    this.context = context;
        //}

        public IActionResult Index()
        {
           HttpContext.Session.SetString("uname", "Laxman");
           HttpContext.Session.SetInt32("password", 1234);
            return (RedirectToAction("Get"));
        }

        
        public IActionResult Get()
        {
            string name= HttpContext.Session.GetString("uname").ToString();
            string password = HttpContext.Session.GetInt32("password").ToString();
            ViewBag.Name = name;
            ViewBag.Password = password;
            return View();
        }

        
    }
}
