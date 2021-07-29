using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Employee;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;
using System.Linq;
using AutoMapper.QueryableExtensions;

namespace TaskManager.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _empRepo;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository empRepo, IMapper mapper)
        {
            _empRepo = empRepo;
            _mapper = mapper;
        }

        public int AddEmploye(AddEmployeeVm model)
        {
            var employee = _mapper.Map<Employee>(model);
            var id = _empRepo.AddEmployee(employee);
            return id;
        }

        public void DeleteEmployee(int id)
        {
            _empRepo.RemoveEmployee(id);
        }

        public EmployeeListVm GetAllEmployee(string searchString)
        {
            var users = _empRepo.GetAllUser().Where(u => u.LastName.Contains(searchString))
                .ProjectTo<EmployeeVm>(_mapper.ConfigurationProvider).ToList();
            var empList = new EmployeeListVm
            {
                Employees = users,
                Count = users.Count
            };
            return empList;
        }
        public EmployeeVm GetEmployee(int id)
        {
            var emp = _empRepo.GetEmployee(id);
            var empVm = _mapper.Map<EmployeeVm>(emp);
            return empVm;
        }

        public void UpdateEmployee(EmployeeVm model)
        {
            var user = _mapper.Map<Employee>(model);
            _empRepo.Update(user);
        }
    }
}
