using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveAcademyMVC.Models
{
    public class InstructorCategory : Audity
    {

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "int")]
        public int InstructorId { get; set; } 

        [Column(TypeName = "int")]
        public int CatAM { get; set; } 

        [Column(TypeName = "int")]
        public int CatA1 { get; set; }

        [Column(TypeName = "int")]
        public int CatA2 { get; set; }

        [Column(TypeName = "int")]
        public int CatA { get; set; }

        [Column(TypeName = "int")]
        public int CatB { get; set; } 

        [Column(TypeName = "int")]
        public int CatB1 { get; set; } 

        [Column(TypeName = "int")]
        public int CatC { get; set; } 

        [Column(TypeName = "int")]
        public int CatC1 { get; set; } 

        [Column(TypeName = "int")]
        public int CatD { get; set; } 

        [Column(TypeName = "int")]
        public int CatD1 { get; set; } 

        [Column(TypeName = "int")]
        public int CatBE { get; set; } 

        [Column(TypeName = "int")]
        public int CatC1E { get; set; }

        [Column(TypeName = "int")]
        public int CatCE { get; set; } 

        [Column(TypeName = "int")]
        public int CatDE { get; set; } 

        [Column(TypeName = "int")]
        public int CatD1E { get; set; } 
                
        [Column(TypeName = "int")]
        public int CatT { get; set; } 
    }
}

