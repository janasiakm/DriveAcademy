using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveAcademyMVC.Models
{
    public class Instructor : Audity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; } = "";

        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; } = "";

        [Column(TypeName = "varchar(10)")]
        public string DateOfBirth { get; set; } = "";

        [Column(TypeName = "varchar(8)")]
        public string IdNumber { get; set; } = "";

    }
}

