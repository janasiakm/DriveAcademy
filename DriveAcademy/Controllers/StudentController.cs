using Application.Dto;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DriveAcademyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [SwaggerOperation(Summary = "Retrieves all Student")]
        [HttpGet]
        public IActionResult Get()
        {
            var student = _studentService.GetAllStudent();
            return Ok(student);
        }

        [SwaggerOperation(Summary = "Retrieves Student by Id")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }



        [SwaggerOperation(Summary = "Add new Student")]
        [HttpPost]
        public IActionResult Create(StudentAddDto newStudent)
        {
            var student = _studentService.AddNewStudent(newStudent);
            return Created($"api/student/{student.Id}", student);
        }


        [SwaggerOperation(Summary = "Delete student")]
        [HttpPost("{id}")]
        public IActionResult Create(int id)
        {
            _studentService.DeleteStudent(id);
            return Ok();
        }
    }
}
