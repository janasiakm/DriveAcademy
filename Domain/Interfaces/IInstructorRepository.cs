using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IInstructorRepository
    {
        IEnumerable<Instructor> GetAll();
        Instructor GetById(int id);
        Instructor Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor);

    }
}
