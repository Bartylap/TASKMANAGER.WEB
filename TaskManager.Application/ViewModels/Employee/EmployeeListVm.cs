using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.ViewModels.Employee
{
    public class EmployeeListVm
    {
        public List<EmployeeVm> Employees { get; set; }
        public int Count { get; set; }
        public string SearchString { get; set; }
        
    }
}
