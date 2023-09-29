using Application.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<StudentDto> GetAllStudent();
        StudentDto GetStudentById(int id);
        StudentDto AddNewStudent(StudentAddDto student);
        void DeleteStudent(int id);

    }
}
