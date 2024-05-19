using Microsoft.AspNetCore.Mvc;
using Query_Strings.Models;
using System.Diagnostics;

namespace Query_Strings.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy(Student st)
        {
            Student l = new Student();
            l.Id = st.Id;
            l.Name = st.Name;
            return View(l);
            
        }

       
    }
}
