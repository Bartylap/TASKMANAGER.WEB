using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.Construction
{
    public class AddEmployeeToConstruction : IMapFrom<TaskManager.Domain.Models.Employee>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public bool Check { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddEmployeeToConstruction, TaskManager.Domain.Models.Employee>().ReverseMap();
        }
    }
}
