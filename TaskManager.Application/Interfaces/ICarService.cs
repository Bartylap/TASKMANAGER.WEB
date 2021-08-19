using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.ViewModels.Car;

namespace TaskManager.Application.Interfaces
{
    public interface ICarService
    {
        CarsListVm GetAllCars(string searchString);
        CarVm Getcar(int id);
        int AddCar(AddCarVm model);
        void DeleteCar(int id);
        void UpdateCar(AddCarVm model);
    }
}
