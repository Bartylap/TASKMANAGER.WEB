using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.Employee
{
    public class AddEmployeeVm : IMapFrom<TaskManager.Domain.Models.Employee>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string Position { get; set; }
        public int HourlyRate { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime DateOfRelease { get; set; }
        public  List<AddEmployeeAdrdressVm> EmployeeAddress { get; set; }
        public List<AddEmployeeContactVm> EmployeeContact { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TaskManager.Domain.Models.Employee, AddEmployeeVm>().ReverseMap()
                .ForMember(d => d.EmployeeAddress, opt => opt.MapFrom(s => s.EmployeeAddress))
                .ForMember(d => d.EmployeeContact, opt => opt.MapFrom(s => s.EmployeeContact));

        }
                 


    }
}
