using DriveAcademyMVC.Models;

namespace DriveAcademyMVC.Services.Interfaces
{
    public interface IInstructorService
    {
        public List<Instructor> GetAll(); 
        public Instructor GetInstructorById(int id);
        public int Save(Instructor instructor);
        public void Update(Instructor instructor);
        public void Delete(Instructor instructor);
        public InstructorCategoryDTO Category(int id);
        public InstructorCategoryDTO UpdateCategory(InstructorCategoryDTO instructorCategory);
    }
}
