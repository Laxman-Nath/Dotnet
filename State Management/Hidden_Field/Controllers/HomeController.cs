using Hidden_Field.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hidden_Field.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        
        public string Index2(Student st)
        {
            //string HDName = fc["HDName"];
            int studentId=st.studentId;
            string studentName=st.studentName;
            //return View(st);
            return " Id:" + studentId + " ,Name:" + studentName;
        }
        

        
    }
}
