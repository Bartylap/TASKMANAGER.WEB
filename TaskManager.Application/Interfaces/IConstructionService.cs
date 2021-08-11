using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Application.ViewModels.Construction;
using TaskManager.Domain.Models;

namespace TaskManager.Application.Interfaces
{
    public interface IConstructionService
    {
        int AddConstruction(AddConstructionVm model);
        ConstructionListVm GetAllConstruction(string searchString);
    }
}
