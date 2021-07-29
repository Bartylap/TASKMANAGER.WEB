using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Models;

namespace TaskManager.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        int AddEmployee(Employee employee);
        void RemoveEmployee(int id);
        IQueryable<Employee> GetAllUser();
        Employee GetEmployee(int id);
        void Update(Employee employee);
    }
}
