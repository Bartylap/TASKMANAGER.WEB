using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;

namespace TaskManager.Infrastructure.Repositories
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly Context _context;

        public WarehouseRepository(Context context)
        {
            _context = context;
        }

        public void AddItems(Item item)
        {
            
            var existItem = _context.Items.FirstOrDefault(i => i.Name == item.Name);
            if (existItem == null)
            {
                _context.Items.Add(item);
                _context.SaveChanges();
            }
            else
            {
                existItem.Quantity = existItem.Quantity + item.Quantity;
                _context.SaveChanges();
            } 
        }

        public IQueryable<Item> GetAllItem()
        {
            return _context.Items;
        }
    }
}
