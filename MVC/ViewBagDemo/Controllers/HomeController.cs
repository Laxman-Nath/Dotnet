using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewBagDemo.Models;


namespace ViewBagDemo.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            ViewBag.Message = "This is the message from viewBag!!!!";
            ViewBag.CurrentDate=DateTime.Now.ToLongDateString();
            ViewBag.FruitsArray = new string[] { "Apple", "mango", "grapes", "Orange", "Banana" };
            ViewBag.Sports=new List<string>() { "Cricket","Football","Volleyball","Badminton"};
            Employee emp = new Employee(2,"laxman","hncom");
            ViewBag.Employee = emp;
            ViewData["CommonMessage"] = "This message is accessible to both viewdata and viewbag";
            return View();
        }

        
    }
}
