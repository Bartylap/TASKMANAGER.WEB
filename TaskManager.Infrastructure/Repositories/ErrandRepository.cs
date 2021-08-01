using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;

namespace TaskManager.Infrastructure.Repositories
{
    public class ErrandRepository : IErrandRepository
    {
        private readonly Context _context;

        public ErrandRepository(Context context)
        {
            _context = context;
        }

        public void AddCategory(Category newCategory)
        {
            _context.Categories.Add(newCategory);
            _context.SaveChanges();
        }

        public int AddErrand(Errand newerrand)
        {
            _context.Errands.Add(newerrand);
            _context.SaveChanges();
            return newerrand.Id;
        }

        public void RemoveErrand(int id)
        {
            var errand = _context.Errands.Find(id);
            _context.Errands.Remove(errand);
            _context.SaveChanges();
        }
    }
}
