using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;
using TaskManager.Domain.Models;

namespace TaskManager.Application.ViewModels.Employee
{
    public class AddEmployeeContactVm : IMapFrom<EmployeeContact>
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TaskManager.Domain.Models.EmployeeContact, AddEmployeeContactVm>().ReverseMap();
        }
    }
}
