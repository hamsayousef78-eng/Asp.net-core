using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, name = "hamsa" });
            students.Add(new Student { Id = 2, name = "yousef" });
            students.Add(new Student { Id = 3, name = "mena" });
            students.Add(new Student { Id = 4, name = "nada" });
            students.Add(new Student { Id = 5, name = "hamsa" });


            return View(students);
        }
    }
}
