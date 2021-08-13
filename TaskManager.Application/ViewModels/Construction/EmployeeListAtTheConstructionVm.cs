using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.Construction
{
    public class EmployeeListAtTheConstructionVm :IMapFrom<TaskManager.Domain.Models.Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Count { get; set; }



        public void Mapping(Profile profile)
        {
            profile.CreateMap<EmployeeListAtTheConstructionVm, TaskManager.Domain.Models.Employee>().ReverseMap();
                
        }
                
          
    }
}
