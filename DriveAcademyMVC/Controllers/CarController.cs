using DriveAcademyMVC.Models;
using DriveAcademyMVC.Services;
using DriveAcademyMVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DriveAcademyMVC.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Car()
        {
            var cars = _carService.GetAll();
            return View(cars);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Car body)
        {
            if (!ModelState.IsValid)
            {
                return View(body);
            }
            var id = _carService.Save(body);
            return RedirectToAction("Add");
        }

        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var car = _carService.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        [HttpPost]
        public IActionResult Edit(Car body)
        {
            if (!ModelState.IsValid)
            {
                return View(body);
            }
            _carService.Update(body);
            return View(body);
        }

        public IActionResult Delete(Car body)
        {
            if (!ModelState.IsValid)
            {
                _carService.Delete(body);
            }
            return RedirectToAction("Car");
        }
    }
}
