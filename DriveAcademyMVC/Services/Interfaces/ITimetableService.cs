using DriveAcademyMVC.Models;

namespace DriveAcademyMVC.Services.Interfaces
{
    public interface ITimetableService
    {  
        public List<Timetable> GetTimetable(int week, int carId);
        public int Save(Timetable timetable);
    }
}
