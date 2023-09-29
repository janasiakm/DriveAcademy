﻿using Application.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarDto> GetAllCars();
        CarDto GetCarById(int id);
        CarDto AddNewCar(CarAddDto carAddDto);
        void DeleteCar(int id);

    }
}
