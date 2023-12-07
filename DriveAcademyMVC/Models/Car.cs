using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveAcademyMVC.Models
{
    public class Car : Audity
    {
        [Key]
        public int CarId { get; set; }


        [Column(TypeName = "varchar(10)")]
        public string Mark { get; set; } = "";

        [Column(TypeName = "varchar(10)")]
        public string Model { get; set; } = "";

        [Column(TypeName = "varchar(10)")]
        public string NrRej { get; set; } = "";

        [Column(TypeName = "int")]
        public int ProdYear { get; set; }

    }
}
