using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;
using TaskManager.Domain.Models;

namespace TaskManager.Application.ViewModels.Employee
{
    public class AddEmployeeAdrdressVm : IMapFrom<EmployeeAddress>
    {
        public int Id { get; set; }
        public string AdressLine1 { get; set; }
        public string BuildingNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TaskManager.Domain.Models.EmployeeAddress, AddEmployeeAdrdressVm>().ReverseMap();
        }
           

    }
}
