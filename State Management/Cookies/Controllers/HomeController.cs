using Cookies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace Cookies.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IHttpContextAccessor _contextAccessor;
        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            _contextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

         public IActionResult SetCookie()
        {
            CookieOptions options = new CookieOptions();
              //options.Expires=DateTime.Now.AddSeconds(10);
              options.Expires=DateTime.Now.AddDays(1);
            _contextAccessor.HttpContext.Response.Cookies.Append("name", "Ram",options);
            return View();
        }
        public IActionResult GetCookie()
        {
            ViewBag.Name = _contextAccessor.HttpContext.Request.Cookies["name"];
            return View();
        }
        public IActionResult DeleteCookie() {
            //CookieOptions options = new CookieOptions();
            //options.Expires=DateTime.Now.AddSeconds(-1);
            //options.Expires = DateTime.Now.AddDays(-1);

            //_contextAccessor.HttpContext.Response.Cookies.Append("name", "Ram", options);
            //ViewBag.Name = _contextAccessor.HttpContext.Request.Cookies["name"];
            Response.Cookies.Delete("name");
            return View();
        }
    }
}
