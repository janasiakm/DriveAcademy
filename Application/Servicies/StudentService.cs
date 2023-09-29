using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public StudentService(IStudentRepository studentRepository, IMapper mapper) 
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public IEnumerable<StudentDto> GetAllStudent()
        {
            var students = _studentRepository.GetAll();
            return _mapper.Map<IEnumerable<StudentDto>>(students);
        }

        public StudentDto GetStudentById(int id)
        {
            var student = _studentRepository.GetById(id);
            return _mapper.Map<StudentDto>(student);
        }

        public StudentDto AddNewStudent(StudentAddDto studentAddDto)
        {
            var student = _mapper.Map<Student>(studentAddDto);
            var result = _studentRepository.Add(student);
            return _mapper.Map<StudentDto>(result);
        }

        public void DeleteStudent(int id)
        {
            var student = _studentRepository.GetById(id);
            _studentRepository.Delete(student);
        }
    }
}
