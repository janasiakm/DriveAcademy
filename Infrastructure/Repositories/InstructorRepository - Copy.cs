using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class InstructorRepositoryDB : IInstructorRepository
    {

        private static readonly ISet<Instructor> _instructors = new HashSet<Instructor>()
        {
            new Instructor(1,"Mateusz","Janasiak","1992-12-06","RKR0210"),
            new Instructor(2,"Rafał","Urbanek","1979-06-05","RK0079"),
            new Instructor(3,"Piotr","Furmański","1970-04-03","RJS0044")
            
        };

        public Instructor Add(Instructor instructor)
        {
            instructor.Id = _instructors.Count()+1;
            instructor.Created = DateTime.UtcNow;
            instructor.CretedBy = "SYS";
            instructor.Modifited = DateTime.UtcNow;

            _instructors.Add(instructor);
            return instructor;
        }

        
        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public IEnumerable<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
           return _instructors.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Instructor instructor)
        {
            instructor.Modifited = DateTime.UtcNow;
        }
    }
}
