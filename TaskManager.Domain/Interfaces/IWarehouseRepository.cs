using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Models;

namespace TaskManager.Domain.Interfaces
{
    public interface IWarehouseRepository
    {
        IQueryable<Item> GetAllItem();
        void AddItems(Item item);
        
    }
}
