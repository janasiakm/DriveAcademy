using Application.Dto;
using Application.Interfaces;
using DriveAcademyApi.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DriveAcademyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        private readonly ICarService _carService;
        private readonly DriveAcademyDbContext _context;

        public CarsController(ICarService carService, DriveAcademyDbContext context)
        {
            _carService = carService;
            _context = context;

        }
        [SwaggerOperation(Summary = "Retrieves all cars")]
        [HttpGet]
        public IActionResult Get()
        {
            //var cars = _context.Cars.
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }

        [SwaggerOperation(Summary = "Retrieves car by Id")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var car = _carService.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }


        [SwaggerOperation(Summary = "Add new car")]
        [HttpPost]
        public IActionResult Create(CarAddDto carAddDto)
        {
            var car = _carService.AddNewCar(carAddDto);
            return Created($"api/cars/{car.CarId}", car);
        }


        [SwaggerOperation(Summary = "Delete car")]
        [HttpPost("{id}")]
        public IActionResult Create(int id)
        {
             _carService.DeleteCar(id);
            return Ok();
        }
    }
}
