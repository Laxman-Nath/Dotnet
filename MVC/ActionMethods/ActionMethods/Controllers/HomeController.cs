using Microsoft.AspNetCore.Mvc;
/* A controller class can contain one or more action methods also known as controller actions.
 * 
 */
namespace ActionMethods.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // This is action method
        {
            return View();
        }

        public string Show()
        {
            return "This is a second action method of home controller";
        }
        
        public IActionResult AboutUs()
        {
            return View();
        }
        public int StudentID(int id)
        {
            return id;
        }
    }
}
