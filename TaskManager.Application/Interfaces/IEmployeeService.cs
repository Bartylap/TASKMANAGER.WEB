using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.ViewModels.Employee;

namespace TaskManager.Application.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeListVm GetAllEmployee(string searchString);
        EmployeeVm GetEmployee(int id);
        int AddEmploye(AddEmployeeVm model);
        void DeleteEmployee(int id);
        void UpdateEmployee(EmployeeVm model);

        
    }
}
