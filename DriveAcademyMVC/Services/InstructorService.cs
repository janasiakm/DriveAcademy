using DriveAcademyMVC.Models;
using DriveAcademyMVC.Services.Interfaces;
using System.Linq;

namespace DriveAcademyMVC.Services
{
    public class InstructorService  : IInstructorService
    {
        private readonly DriveAcademyDbContext _context;

        public InstructorService(DriveAcademyDbContext context)
        {
            _context = context;
        }

        public List<Instructor> GetAll()
        {
            var instructor = _context.Instructors.ToList<Instructor>();
            return instructor;
        }

        public Instructor GetInstructorById(int id)
        {
            var result = _context.Instructors.FirstOrDefault<Instructor>(x=>x.Id == id);
            return result;
        }

        public int Save(Instructor instructor)
        {
            instructor.Created = DateTime.Now;
            instructor.Modification = DateTime.Now;
            int maxId = _context.Instructors.Max(instructor => instructor.Id) + 1;
            InstructorCategory newInstructorCategory = new InstructorCategory { 
                InstructorId = maxId,
                Created=DateTime.Now,
                Modification=DateTime.Now
            };
            _context.Instructors.Add(instructor);
            _context.InstructorCategory.Add(newInstructorCategory);
            _context.SaveChanges();
                       
            return 1;
        }
        
        public void Update(Instructor instructor)
        {
            var instructorDb = _context.Instructors.FirstOrDefault<Instructor>(x => x.Id == instructor.Id);

            instructorDb.FirstName = instructor.FirstName;
            instructorDb.LastName = instructor.LastName;
            instructorDb.DateOfBirth = instructor.DateOfBirth;
            instructorDb.IdNumber = instructor.IdNumber;

            instructorDb.Modification = DateTime.Now;
                                   
            _context.SaveChanges();
        }

        public void Delete(Instructor instructor)
        {
            _context.Instructors.Remove(instructor);
            _context.SaveChanges();
        }

        public InstructorCategoryDTO Category(int id)
        {
            var instructorDb = _context.InstructorCategory.FirstOrDefault<InstructorCategory>(x => x.InstructorId == id);
            var instructorName = GetInstructorById(id);
            var instructorDTO = new InstructorCategoryDTO { };

            if (instructorDb != null)
            {
                instructorDTO.Id = instructorDb.Id;
                instructorDTO.InstructorId = instructorDb.InstructorId;
                instructorDTO.FirstName = instructorName.FirstName;
                instructorDTO.LastName = instructorName.LastName;
                instructorDTO.CatAM = (instructorDb.CatAM == 1 ? true : false);
                instructorDTO.CatA1 = (instructorDb.CatA1 == 1 ? true : false);
                instructorDTO.CatA2 = (instructorDb.CatA2 == 1 ? true : false);
                instructorDTO.CatA = (instructorDb.CatA == 1 ? true : false);
                instructorDTO.CatB1 = (instructorDb.CatB1 == 1 ? true : false);
                instructorDTO.CatB = (instructorDb.CatB == 1 ? true : false);
                instructorDTO.CatC1 = (instructorDb.CatC1 == 1 ? true : false);
                instructorDTO.CatC = (instructorDb.CatC == 1 ? true : false);
                instructorDTO.CatD1 = (instructorDb.CatD1 == 1 ? true : false);
                instructorDTO.CatD = (instructorDb.CatD == 1 ? true : false);
                instructorDTO.CatBE = (instructorDb.CatBE == 1 ? true : false);
                instructorDTO.CatC1E = (instructorDb.CatC1E == 1 ? true : false);
                instructorDTO.CatCE = (instructorDb.CatCE == 1 ? true : false);
                instructorDTO.CatD1E = (instructorDb.CatD1E == 1 ? true : false);
                instructorDTO.CatDE = (instructorDb.CatDE == 1 ? true : false);
                instructorDTO.CatT = (instructorDb.CatT == 1 ? true : false);
                instructorDTO.Created = instructorDb.Created;
                instructorDTO.Modification = instructorDb.Modification;
            }
            return instructorDTO;     
        }

        public InstructorCategoryDTO UpdateCategory(InstructorCategoryDTO instructorCategory) 
        {
            var instructorCategoryDb = _context.InstructorCategory.FirstOrDefault<InstructorCategory>(x => x.InstructorId == instructorCategory.Id);
            
            instructorCategoryDb.CatAM = (instructorCategory.CatAM ? 1:0);
            instructorCategoryDb.CatA1 = (instructorCategory.CatA1 ? 1 : 0);
            instructorCategoryDb.CatA2 = (instructorCategory.CatA2 ? 1 : 0);
            instructorCategoryDb.CatA = (instructorCategory.CatA ? 1 : 0);
            instructorCategoryDb.CatB1 = (instructorCategory.CatB1 ? 1 : 0);
            instructorCategoryDb.CatB = (instructorCategory.CatB ? 1 : 0);
            instructorCategoryDb.CatC1 = (instructorCategory.CatC1 ? 1 : 0);
            instructorCategoryDb.CatC = (instructorCategory.CatC ? 1 : 0);
            instructorCategoryDb.CatD1 = (instructorCategory.CatD1 ? 1 : 0);
            instructorCategoryDb.CatD = (instructorCategory.CatD ? 1 : 0);
            instructorCategoryDb.CatBE = (instructorCategory.CatBE ? 1 : 0);
            instructorCategoryDb.CatC1E = (instructorCategory.CatC1E ? 1 : 0);
            instructorCategoryDb.CatCE = (instructorCategory.CatCE ? 1 : 0);
            instructorCategoryDb.CatD1E = (instructorCategory.CatD1E ? 1 : 0);
            instructorCategoryDb.CatDE = (instructorCategory.CatDE ? 1 : 0);
            instructorCategoryDb.CatT = (instructorCategory.CatT ? 1 : 0);

            instructorCategoryDb.Modification = DateTime.Now;
            _context.SaveChanges();

            return instructorCategory;
        }
    }
}
