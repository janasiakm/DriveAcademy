using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Timetable
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Week { get; set; }
        public int Hour { get; set; }
        public int CarId { get; set; }
        public int InstructorId { get; set; }
        public int StudentId { get; set; }


        public Timetable() { }

        public Timetable(int id, int year, int week, int hour, int carId, int instructorId, int studentId) 
        {
            (id, year, week, hour, carId, instructorId, studentId) = (Id, Year, Week, Hour, CarId, InstructorId, StudentId);
        
        }
    }
}
