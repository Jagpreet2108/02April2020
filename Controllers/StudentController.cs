using Microsoft.AspNetCore.Mvc;

namespace _03April2020.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {          
            return View();
        }
    }
}