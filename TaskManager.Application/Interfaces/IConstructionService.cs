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
        int Copy(int id);
        int AddConstruction(AddConstructionVm model);
        ConstructionListVm GetAllConstruction(string searchString);
        DetailsConstructionVm GetConstruction(int id);
        void UpdateConstruction(DetailsConstructionVm model);
        AddConstructionVm GetToClone(int id);
        AddEmployeeToConstructionList AddEmployeeToConstructionView(int id);
        void AddEmployeeToConstruction(AddEmployeeToConstructionList model);
    }
}
