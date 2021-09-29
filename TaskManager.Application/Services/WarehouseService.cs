using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Warehouse;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;

namespace TaskManager.Application.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseRepository _warRepo;
        private readonly IMapper _mapper;
        public WarehouseService(IWarehouseRepository warRepo , IMapper mapper)
        {
            _warRepo = warRepo;
            _mapper = mapper;
        }

        public void AddItems(AddItemVm model)
        {
            var item = _mapper.Map<Item>(model);
             _warRepo.AddItems(item);
            
        }

        public ItemListVm GetAllItems(string searchString)
        {
            var items = _warRepo.GetAllItem().Where(i => i.Name.Contains(searchString))
                .ProjectTo<ItemVm>(_mapper.ConfigurationProvider).ToList();
            var itemsList = new ItemListVm()
            {
                Items = items,
                Count = items.Count
            };
            return itemsList;
        }
    }
}
