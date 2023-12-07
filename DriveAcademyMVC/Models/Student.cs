using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveAcademyMVC.Models
{
    public class Student : Audity
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")] 
        public string FirstName { get; set; } = "";

        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; } = "";
        [Column(TypeName = "varchar(8)")]
        public string DateOfBirth { get; set; } = "";
        [Column(TypeName = "varchar(10)")]
        public string PhoneNumber { get; set; } = "";

        [Column(TypeName = "varchar(2)")]
        public string Category { get; set; } = "";

        [Column(TypeName = "int")]
        public int PassTeory { get; set; }
        
    }
}
