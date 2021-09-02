using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.ViewModels.Construction
{
    public class AddEmployeeToConstructionList
    {
        public List<AddEmployeeToConstruction> Employee { get; set; }
        public int ConstructionId { get; set; }
        public int EmployeeId { get; set;}
        public int Count { get; set; }
    }
}
