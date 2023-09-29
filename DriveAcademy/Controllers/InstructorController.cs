using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DriveAcademyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : Controller
    {
        private readonly IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;

        }
        [SwaggerOperation(Summary = "Retrieves all instructors")]
        [HttpGet]
        public IActionResult Get()
        {
            var instructor = _instructorService.GetAllInstructors();
            return Ok(instructor);
        }

        [SwaggerOperation(Summary = "Retrieves instructor by Id")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var instructor = _instructorService.GetInstructorById(id);
            if (instructor == null)
            {
                return NotFound();
            }
            return Ok(instructor);
        }



        [SwaggerOperation(Summary = "Add new instructor")]
        [HttpPost]
        public IActionResult Create(InstructorAddDto instructorAddDto)
        {
            var instructor = _instructorService.AddNewInstructor(instructorAddDto);
            return Created($"api/instructor/{instructor.Id}", instructor);
        }


        [SwaggerOperation(Summary = "Delete instructor")]
        [HttpPost("{id}")]
        public IActionResult Create(int id)
        {
            _instructorService.DeleteInstructor(id);
            return Ok();
        }
    }
}
