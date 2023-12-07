using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveAcademyApi.Models
{
    public class Car
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

        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Modification { get; set; }
    

}
}
