using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;

namespace TaskManager.Infrastructure.Repositories
{
    class ConstructionRepository : IConstructionRepository
    {
        private readonly Context _context;

        public ConstructionRepository(Context context)
        {
            _context = context;
        }

        public int AddConstruction(Construction cstr)
        {
            cstr.Id = 0;
            _context.Constructions.Add(cstr);
            _context.SaveChanges();
            return cstr.Id;
        }

        public void AddEmployeeToConstruction(ConstructionEmployee result)
        {
            _context.ConstructionEmployee.Add(result);
            _context.SaveChanges();
        }
        public void AddItemToConstruction(ConstructionItem ie)
        {
            _context.ConstructionItem.Add(ie);
            _context.SaveChanges();
        }

        public IQueryable<Construction> GetAllConstruction()
        {
            return _context.Constructions.AsNoTracking();


        }

        public Construction GetConstruction(int cstrId)
        {

            var construction = _context.Constructions.AsNoTracking()
                .Include(e => e.ConstructionEmployees).ThenInclude(e => e.Employee)
                .Include(e => e.ConstructionItems).ThenInclude(e=>e.Item)
                .Include(e => e.Car)
                .Include(e => e.Flat)
                .FirstOrDefault(e => e.Id == cstrId);


            return construction;
        }

        public void UpdateConsrtuction(Construction model)
        {
            _context.Constructions.Update(model);
            _context.SaveChanges();
        }


        public void RemoveEmployeeFromConstruction(int empId , int consId)
        {

            var model = _context.ConstructionEmployee.FirstOrDefault(u => u.EmployeeId == empId && u.ConstructionId==consId);

            _context.ConstructionEmployee.Remove(model);
            _context.SaveChanges();
        }


    }
}
