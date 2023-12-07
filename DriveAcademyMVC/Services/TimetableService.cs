using DriveAcademyMVC.Models;
using DriveAcademyMVC.Services.Interfaces;

namespace DriveAcademyMVC.Services
{
    public class TimetableService : ITimetableService
    {
        private readonly DriveAcademyDbContext _context;
        public TimetableService(DriveAcademyDbContext context)
        {
            _context = context;
        }

        public List<Timetable> GetTimetable(int week, int carId)
        {
           return _context.Timetables.ToList<Timetable>();
        }

        public int Save(Timetable timetable)
        {
            
            timetable.HourStop = timetable.HourStart.AddHours(timetable.Hour);
            timetable.Created = DateTime.Now;
            timetable.Modification = DateTime.Now;

            _context.Timetables.Add(timetable);
            _context.SaveChanges();
            return timetable.Id;
        }
    }
}
