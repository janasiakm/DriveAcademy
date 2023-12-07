using DriveAcademyMVC.Models;
using DriveAcademyMVC.Services.Interfaces;

namespace DriveAcademyMVC.Services
{
    public class CarService: ICarService
    {
        private readonly DriveAcademyDbContext _context;

        public CarService(DriveAcademyDbContext context)
        {
            _context = context;
        }

        public List<Car> GetAll()
        {
            var cars = _context.Cars.ToList<Car>();
            return cars;
        }

        public Car GetCarById(int id)
        {
            var car = _context.Cars.FirstOrDefault<Car>(x => x.CarId == id);
            return car;
        }

        public int Save(Car car)
        {
            car.Created = DateTime.Now;
            car.Modification = DateTime.Now;
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car.CarId;
        }

        public void Update(Car car)
        {
            var baza = _context.Cars.FirstOrDefault<Car>(x => x.CarId == car.CarId);
            
            baza.Mark = car.Mark;
            baza.Model = car.Model;
            baza.ProdYear = car.ProdYear;
            baza.NrRej = car.NrRej;
            baza.Modification = DateTime.Now;

            _context.SaveChanges();
        }

        public void Delete(Car car)
        {
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }

    }
}
