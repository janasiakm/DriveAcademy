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
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;
        private readonly IMapper _mapper;
        public InstructorService(IInstructorRepository instructorRepository, IMapper mapper) 
        {
            _instructorRepository = instructorRepository;
            _mapper = mapper;
        }

        public IEnumerable<InstructorDto> GetAllInstructors()
        {
            var instructors = _instructorRepository.GetAll();
            return _mapper.Map<IEnumerable<InstructorDto>>(instructors);
            
        }

        public Instructor GetInstructorById(int id)
        {
            var instructor = _instructorRepository.GetById(id);
            return _mapper.Map<Instructor>(instructor);
        }

        public Instructor AddNewInstructor(InstructorAddDto instructorAddDto)
        {
            var instructor = _mapper.Map<Instructor>(instructorAddDto);
            var result = _instructorRepository.Add(instructor);
            return _mapper.Map<Instructor>(result);
        }

        public void DeleteInstructor(int id)
        {
            var instructor = _instructorRepository.GetById(id);
            _instructorRepository.Delete(instructor);
        }
    }
}
