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
    }
}
