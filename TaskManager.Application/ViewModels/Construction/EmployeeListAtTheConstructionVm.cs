using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.Construction
{
    public class EmployeeListAtTheConstructionVm :IMapFrom<TaskManager.Domain.Models.Employee>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        



        public void Mapping(Profile profile)
        {
            profile.CreateMap<EmployeeListAtTheConstructionVm, TaskManager.Domain.Models.Employee>().ReverseMap()
                     .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                     .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName));


        }
                
          
    }
}
