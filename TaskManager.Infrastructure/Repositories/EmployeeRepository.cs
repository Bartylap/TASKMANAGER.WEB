using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;

namespace TaskManager.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;
        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public int AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee.Id;
            
        }

        public IQueryable<Employee> GetAllUser()
        {
            return _context.Employees;
           
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.AsNoTracking()
                .Include(e => e.EmployeeAddress)
                .Include(e => e.EmployeeContact)
                .FirstOrDefault(u => u.Id == id);
        }


        public void RemoveEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            var empadress = _context.EmployeeAddresses.FirstOrDefault(u => u.Employee.Id == id);
            var empcon= _context.EmployeeContacts.FirstOrDefault(u => u.Employee.Id == id);

            if (empadress != null)
            {
                _context.EmployeeAddresses.Remove(empadress);
            }
            if (empcon != null)
            {
                _context.EmployeeContacts.Remove(empcon);
            }
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }
    }
}
