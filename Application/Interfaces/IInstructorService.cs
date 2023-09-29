using Application.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IInstructorService
    {
        IEnumerable<InstructorDto> GetAllInstructors();
        Instructor GetInstructorById(int id);
        Instructor AddNewInstructor(InstructorAddDto instructor);
        void DeleteInstructor(int id);

    }
}
