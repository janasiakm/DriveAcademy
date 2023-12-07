using Microsoft.AspNetCore.Mvc;
using DriveAcademyMVC.Models;
using DriveAcademyMVC.Services.Interfaces;

namespace DriveAcademyMVC.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService) 
        {
            _instructorService = instructorService;
        }
        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult Instructor() 
        {
            var instructors = _instructorService.GetAll();
            return View(instructors);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Instructor body) 
        {
            if (!ModelState.IsValid) 
            {
                return View(body);
            }
            var id = _instructorService.Save(body);
            return RedirectToAction("Add");
        }

        [HttpPost]
        public IActionResult Edit(Instructor body) 
        {
            if (!ModelState.IsValid) 
            {
                return View(body);
            }
            _instructorService.Update(body);
            return View(body);
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var instructor = _instructorService.GetInstructorById(id);
            if (instructor == null) 
            {
                return NotFound();
            }
            return View(instructor);
        }

        [HttpPost]
        public IActionResult Delete(Instructor body)
        {
            if (!ModelState.IsValid)
            {
                _instructorService.Delete(body);
            }
            return RedirectToAction("Instructor");
        }
        [HttpGet]
        public IActionResult Category(int id)
        {
            var instructorCategory = _instructorService.Category(id);
            if (instructorCategory.InstructorId == 0 )
            {
                return NotFound();
            }
            return View(instructorCategory);
        }

        [HttpPost]
        public IActionResult Category(InstructorCategoryDTO body)
        {
            var result = _instructorService.UpdateCategory(body);
            return View(result);
        }
    }

}

