using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student : AuditableEntitycs

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Category { get; set; }
        public bool Teory { get; set; }



        public Student() { }

        public Student(int id, string firstName, string lastName, string dateOfBirth, string phoneNumber, string category, bool teory)
        {
            (Id, FirstName, LastName, DateOfBirth, PhoneNumber, Category, Teory) = (id, firstName, lastName, dateOfBirth, phoneNumber, category, teory);
        }
    }
}
