using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;
using TaskManager.Domain.Models;

namespace TaskManager.Application.ViewModels.Construction
{
    public class ToolListAtTheConstructionVm : IMapFrom<TaskManager.Domain.Models.Item>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Qantity { get; set; }



        public void Mapping(Profile profile)
        {
            profile.CreateMap<ToolListAtTheConstructionVm, Item>().ReverseMap();
        }
    }
}
