using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Models;

namespace TaskManager.Domain.Interfaces
{
    public interface IErrandRepository
    {
        int AddErrand(Errand newerrand);
        void RemoveErrand(int id);
        void AddCategory(Category newCategory);
    }
}
