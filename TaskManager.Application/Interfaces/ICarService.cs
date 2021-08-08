using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.ViewModels.Car;

namespace TaskManager.Application.Interfaces
{
    public interface ICarService
    {
        CarsListVm GetAllCars(string searchString);
        CarVm GetEmployee(int id);
        int AddEmploye(AddCarVm model);
        void DeleteEmployee(int id);
        void UpdateEmployee(CarVm model);
    }
}
