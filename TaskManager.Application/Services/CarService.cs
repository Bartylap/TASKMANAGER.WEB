using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Car;
using TaskManager.Domain.Interfaces;

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

        public int AddEmploye(AddCarVm model)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public CarsListVm GetAllCars(string searchString)
        {
            throw new NotImplementedException();
        }

        public CarVm GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(CarVm model)
        {
            throw new NotImplementedException();
        }
    }
}
