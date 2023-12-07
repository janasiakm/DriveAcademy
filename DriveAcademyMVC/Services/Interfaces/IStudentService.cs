using DriveAcademyMVC.Models;

namespace DriveAcademyMVC.Services.Interfaces
{
    public interface IStudentService
    {

        public List<Student> GetAll();

        public Student GetStudentById(int id);

        public int Save(Student student);
        public void Update(Student student);
        public void Delete(Student student);
    }
}
