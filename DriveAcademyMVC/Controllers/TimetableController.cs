using DriveAcademyMVC.Models;
using DriveAcademyMVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DriveAcademyMVC.Controllers
{
    public class TimetableController : Controller
    {
        private readonly ITimetableService _timetableService;
        public TimetableController(ITimetableService timetableService)
        {
            _timetableService = timetableService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Timetable()
        {
            var wynik = _timetableService.GetTimetable(1, 1);
            return View(wynik);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Timetable body)
        {
            if (!ModelState.IsValid)
            {
                return View(body);
            }
            var id = _timetableService.Save(body);
            return RedirectToAction("Add");
        }
    }
}
