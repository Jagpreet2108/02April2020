using Microsoft.AspNetCore.Mvc;

namespace _03April2020.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            string[] StudentName = new string[] { "Vicky","Radhika","Kartik","Nikita","Ajay" };
            return View(StudentName);
        }
    }
}