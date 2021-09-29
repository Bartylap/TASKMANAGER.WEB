using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;
using TaskManager.Domain.Models;

namespace TaskManager.Application.ViewModels.Construction
{
    public class AddItemToConstructionVm : IMapFrom<Item>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qantity { get; set ; }
        public bool Check { get; set; }
        
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddItemToConstructionVm, TaskManager.Domain.Models.Item>().ReverseMap();
        }
                
            
    }
}
