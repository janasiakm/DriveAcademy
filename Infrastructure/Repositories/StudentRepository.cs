using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        private static readonly ISet<Student> _student = new HashSet<Student>()
        {
            new Student(1,"Jan","Kowalski","2002-01-05","789789789","B",false),
            new Student(2,"Piotr","Nowak","2003-02-03","123456789","A2",false),
            
        };

        public Student Add(Student student)
        {
            student.Id = _student.Count()+1;
            student.Created = DateTime.UtcNow;
            student.CretedBy = "Init";
            student.Modifited = DateTime.UtcNow;

            _student.Add(student);
            return student;
        }

        
        public void Delete(Student student)
        {
            _student.Remove(student);
        }

        public IEnumerable<Student> GetAll()
        {
            return _student;
        }

        public Student GetById(int id)
        {
           return _student.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Student student)
        {
            student.Modifited = DateTime.UtcNow;
        }
    }
}
