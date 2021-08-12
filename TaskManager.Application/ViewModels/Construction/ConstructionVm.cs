using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.Construction
{
    public class ConstructionVm : IMapFrom<TaskManager.Domain.Models.Construction>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public DateTime Date { get; set; } 
        public List<EmployeeListAtTheConstructionVm> Employee { get; set; }

        public void Mapping (Profile profile)
        {
            profile.CreateMap<ConstructionVm, TaskManager.Domain.Models.Construction>().ReverseMap();
        }
    }
}
