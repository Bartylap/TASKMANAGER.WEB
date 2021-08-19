using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;

namespace TaskManager.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly Context _context;
        public CarRepository(Context context)
        {
            _context = context;
        }


        public int AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car.Id;
        }

        public void DeleteCar(int id)
        {
            var car = _context.Cars.Find(id);
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }

        public IQueryable<Car> GetAllCars()
        {
            return _context.Cars;
        }
        public Car GetCar(int id)
        {
            var car = _context.Cars.AsNoTracking().FirstOrDefault(e => e.Id == id);
            return car;
        }

        public void UpdateCar(Car model)
        {
            _context.Cars.Update(model);
            _context.SaveChanges();
        }
    }
}
