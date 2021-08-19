using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Car;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;

namespace TaskManager.Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepo;
        private readonly IMapper _mapper;


        public CarService(ICarRepository carRepo, IMapper mapper)
        {
            _carRepo = carRepo;
            _mapper = mapper;
        }

        public int AddCar(AddCarVm model)
        {
            var car = _mapper.Map<Car>(model);
            var id = _carRepo.AddCar(car);
            return id;
        }

        public void DeleteCar(int id)
        {
            _carRepo.DeleteCar(id);
        }

        public CarsListVm GetAllCars(string searchString)
        {
            var cars = _carRepo.GetAllCars().Where(c => c.Model.Contains(searchString) ||
                                                        c.Brand.Contains(searchString) ||
                                                        c.VehicleRegistrationNumber.Contains(searchString))
                .ProjectTo<CarVm>(_mapper.ConfigurationProvider).ToList();
            var carList = new CarsListVm()
            {
                Cars = cars,
                Count = cars.Count
            };
            return carList;
        }

        public CarVm Getcar(int id)
        {
            var car = _carRepo.GetCar(id);
            var model = _mapper.Map<CarVm>(car);
            return model;
        }

        public void UpdateCar(AddCarVm model)
        {
            var car = _mapper.Map<Car>(model);
            _carRepo.UpdateCar(car);
        }
    }
    
}
