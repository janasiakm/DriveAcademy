using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveAcademyMVC.Models
{
    public class Timetable : Audity
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "int")]
        public int Year { get; set; }

        [Column(TypeName = "int")]
        public int Week { get; set; }

        [Column(TypeName = "int")]
        public int Hour { get; set; }

        [Column(TypeName = "int")]
        public int CarId { get; set; }

        [Column(TypeName = "int")]
        public int InstructorId { get; set; }

        [Column(TypeName = "int")]
        public int StudentId { get; set; }

        [Column(TypeName = "int")]
        public int Paid { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime HourStart { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime HourStop { get; set; }

    }
}
