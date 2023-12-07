using Microsoft.EntityFrameworkCore;

namespace DriveAcademyMVC.Models
{
    public class DriveAcademyDbContext : DbContext
    {
        public DriveAcademyDbContext(DbContextOptions options) : base(options)       
        {}

        public DbSet<Car> Cars { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Timetable> Timetables { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<InstructorCategory> InstructorCategory { get; set; }
    }
}
