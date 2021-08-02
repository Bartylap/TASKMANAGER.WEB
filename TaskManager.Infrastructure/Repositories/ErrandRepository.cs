using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IQueryable<Errand> GetAll()
        {
            return _context.Errands;
        }

        public Errand GetErrand(int errandId)
        {
            var errand = _context.Errands.FirstOrDefault(e => e.Id == errandId);
            return errand;
        }

        public IQueryable<Category> GetErrandsCategory()
        {
            var category = _context.Categories.AsNoTracking();
            return category;
        }
        public IQueryable<Status> GetErrandsStatus()
        {
            var status = _context.Statuses.AsNoTracking();
            return status;
        }
        public void RemoveErrand(int id)
        {
            var errand = _context.Errands.Find(id);
            _context.Errands.Remove(errand);
            _context.SaveChanges();
        }

        public void UpdateErrand(Errand errand)
        {
             _context.Errands.Update(errand);
            _context.SaveChanges();
        }
    }
}
