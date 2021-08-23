using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.ViewModels.Employee;

namespace TaskManager.Application.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeListVm GetAllEmployee(string searchString);

        int AddEmploye(AddEmployeeVm model);
        void DeleteEmployee(int id);
        void UpdateEmployee(AddEmployeeVm model);
        AddEmployeeVm GetEmployee(int id);
        void ExportEmployee();
        void ImportEmployee();
    }
}
