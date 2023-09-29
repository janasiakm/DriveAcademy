using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {

        private static readonly ISet<Car> _cars = new HashSet<Car>()
        {
            new Car(1,"KIA","RIO","RKR 22670"),
            new Car(2,"KIA","RIO","RZ 0000")
        };

        public Car Add(Car car)
        {
            car.CarId = _cars.Count()+1;
            car.Created = DateTime.UtcNow;
            car.CretedBy = "Wiw";
            car.Modifited = DateTime.UtcNow;
            
            _cars.Add(car);
            return car;
        }

        
        public void Delete(Car car)
        {   
            _cars.Remove(car);
        }

        public IEnumerable<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
           return _cars.SingleOrDefault(x => x.CarId == id);
        }

        public void Update(Car car)
        {
            car.Modifited = DateTime.UtcNow;
        }
    }
}
