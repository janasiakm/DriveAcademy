using DriveAcademyMVC.Models;
using DriveAcademyMVC.Services.Interfaces;

namespace DriveAcademyMVC.Services
{
    public class StudentService: IStudentService
    {
        private readonly DriveAcademyDbContext _context;

        public StudentService(DriveAcademyDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
            var result = _context.Students.ToList<Student>();
            return result;
        }

        public Student GetStudentById(int id)
        {
            var student = _context.Students.FirstOrDefault<Student>(x => x.Id == id);
            return student;        
        }

        public int Save(Student student)
        {
            student.PassTeory = 0;
            student.Created = DateTime.Now;
            student.Modification = DateTime.Now;

            _context.Students.Add(student);
            _context.SaveChanges();

            return student.Id;
        }

        public void Update(Student student)
        {
            var baza = _context.Students.FirstOrDefault<Student>(x => x.Id == student.Id);

            baza.FirstName = student.FirstName;
            baza.LastName = student.LastName;
            baza.PhoneNumber = student.PhoneNumber;
            baza.Category = student.Category;
            baza.Modification = DateTime.Now;

            _context.SaveChanges();
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }


    }
}
