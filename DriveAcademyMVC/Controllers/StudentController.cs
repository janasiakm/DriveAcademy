using DriveAcademyMVC.Models;
using DriveAcademyMVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DriveAcademyMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)        {
            _studentService = studentService;
        }
        public IActionResult Index(){
            return View();
        }

        public IActionResult Student(){
            var students = _studentService.GetAll();
            return View(students);
        }

        [HttpPost]
        public IActionResult Add(Student body){
            if (!ModelState.IsValid){
                return View(body);
            }

            var id = _studentService.Save(body);
            TempData["Studentid"] = id;
            return RedirectToAction("Add");
        }

        [HttpGet]
        public IActionResult Add(){
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Student body){
            if (!ModelState.IsValid){
                return View(body);
            }
            _studentService.Update(body);
            return View(body);
        }

        [HttpGet]
        public IActionResult Edit(int id){
            var student = _studentService.GetStudentById(id);
            if (student == null){
                return NotFound();
            }
            return View(student);
        }

        public IActionResult Delete(Student body){
            if (!ModelState.IsValid){
                _studentService.Delete(body);
            }
            return RedirectToAction("Student");
        }
    }
}
