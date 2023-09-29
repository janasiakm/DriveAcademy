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
        List<Student> GetAllStudent();
        Student GetStudentById(int id);
        Student AddNewStudent(StudentAddDto student);
        void DeleteStudent(int id);

    }
}
