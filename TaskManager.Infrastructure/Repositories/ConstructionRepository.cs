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
            _context.Constructions.Add(cstr);
            _context.SaveChanges();
            return cstr.Id;
        }

        public IQueryable<Construction> GetAllConstruction()
        {
            return _context.Constructions;
        }

        public Construction GetConstruction(int cstrId)
        {
            var construction = _context.Constructions.AsNoTracking()
                .Include(e => e.Employees)
                .Include(e => e.Tolls)
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
    }
}
