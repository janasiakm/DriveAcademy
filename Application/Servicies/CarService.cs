using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public CarService(ICarRepository carRepository, IMapper mapper) 
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public IEnumerable<CarDto> GetAllCars()
        {
            var cars = _carRepository.GetAll();
            return _mapper.Map<IEnumerable<CarDto>>(cars);
        }

        public CarDto GetCarById(int id)
        {
            var car = _carRepository.GetById(id);
            return _mapper.Map<CarDto>(car);
        }

        public CarDto AddNewCar(CarAddDto carAddDto)
        {
            var car = _mapper.Map<Car>(carAddDto);
            var result = _carRepository.Add(car);
            return _mapper.Map<CarDto>(result);
        }

        public void DeleteCar(int id)
        {
            var car = _carRepository.GetById(id);
            _carRepository.Delete(car);
        }
    }
}
