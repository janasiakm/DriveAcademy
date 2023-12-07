using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveAcademyApi.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; } = "";

        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; } = "";

        [Column(TypeName = "varchar(10)")]
        public string DateOfBirth { get; set; } = "";

        [Column(TypeName = "varchar(8)")]
        public string IdNumber { get; set; } = "";

        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Modification { get; set; }
    }
}

