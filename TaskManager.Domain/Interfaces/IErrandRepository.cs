using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Models;

namespace TaskManager.Domain.Interfaces
{
    public interface IErrandRepository
    {
        int AddErrand(Errand newerrand);
        void RemoveErrand(int id);
        void AddCategory(Category newCategory);
        IQueryable<Errand> GetAll();
        Errand GetErrand(int errandId);
        IQueryable<Category> GetErrandsCategory();
        IQueryable<Status> GetErrandsStatus();
        void UpdateErrand(Errand errand);
        void AddErrandToUser(MyUserErrand result);
    }
}
