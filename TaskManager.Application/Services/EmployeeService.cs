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
using System.Xml.Serialization;
using System.IO;
using Microsoft.Win32;
using System.Windows;

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

        public AddEmployeeVm GetEmployee(int id)
        {
            var emp = _empRepo.GetEmployee(id);
            var model = _mapper.Map<AddEmployeeVm>(emp);
            return model;
        }

        public void UpdateEmployee(AddEmployeeVm model)
        {
            var employee = _mapper.Map<Employee>(model); 
            _empRepo.Update(employee);
        }



        public void ExportEmployee()
        {
            var list = _empRepo.GetAllUser().ToList();
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "Employee";
            root.IsNullable = true;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>), root);
            StreamWriter sw = new StreamWriter(@"C:\XML\employee.xml") ;
            xmlSerializer.Serialize(sw, list);
        }
        public void ImportEmployee()
        {
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "Employee";
            root.IsNullable = true;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>), root);
            string xml = File.ReadAllText(@"C:\XML\employee.xml");
            StringReader stringReader = new StringReader(xml);
            var xmlEmployee = (List<Employee>)xmlSerializer.Deserialize(stringReader);
        }
    }
}
