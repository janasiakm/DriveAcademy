using DriveAcademyMVC.Models;

namespace DriveAcademyMVC.Services.Interfaces
{
    public interface ICarService

    {
        public List<Car> GetAll();
        public Car GetCarById(int id);
        public int Save(Car car);
        public void Update(Car car);
        public void Delete(Car car);
    }
}
