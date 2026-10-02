using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebApplication1.Models;
using WebApplication1.Models.Services;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {

        private IStudentService _studentService;
        //constructor
        public StudentController (IStudentService studentService)//هيتعمل اوبجت من ال class studentservice من خلال ال container
        {
            this._studentService = studentService;
        }
        public IActionResult Index()
        {
            var Students = _studentService.GetStudents();
            return View(Students);
        }
        public IActionResult Details(int id)
        {
            var Students = _studentService.GetById(id);
            return View(Students);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _studentService.AddStudent(student);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)//دي هتتنفذ اول ما ادوس ع Edit
        {
            var Student = _studentService.GetById(id);
            return View(Student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)//دي هتتنفذ بعد التعديل لما ادوس ع save
        {
            _studentService.UpdateStudent(student);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var Student = _studentService.GetById(id);
            return View(Student);
        }
        [HttpPost]
        public IActionResult Delete(Student student)
        {
            _studentService.DeleteStudent(student.Id);
            return RedirectToAction("Index");
        }

    }
}
