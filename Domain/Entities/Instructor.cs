using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Instructor : AuditableEntitycs

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string IdNumber { get; set; }



        public Instructor() { }

        public Instructor(int id, string firstName, string lastName, string dateOfBirth, string idNumber)
        {
            (Id, FirstName, LastName, DateOfBirth, IdNumber) = (id, firstName, lastName, dateOfBirth, idNumber);       
        }

}
}
