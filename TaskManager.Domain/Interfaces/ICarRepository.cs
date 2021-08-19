using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Models;

namespace TaskManager.Domain.Interfaces
{
    public interface ICarRepository
    {
        Car GetCar(int id);
        IQueryable<Car> GetAllCars();
        int AddCar(Car car);
        void UpdateCar(Car model);

        void DeleteCar(int id);
    }
}
