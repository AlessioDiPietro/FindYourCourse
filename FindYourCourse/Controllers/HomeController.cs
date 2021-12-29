using Microsoft.AspNetCore.Mvc;

namespace FindYourCourse.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}