using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.ViewModels.Warehouse;

namespace TaskManager.Application.Interfaces
{
    public interface IWarehouseService
    {
        ItemListVm GetAllItems(string searchString);
        void AddItems(AddItemVm model);

    }
}
