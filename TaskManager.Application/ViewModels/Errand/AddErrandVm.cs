using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.Errand
{
    public class AddErrandVm : IMapFrom<TaskManager.Domain.Models.Errand>
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int StatusId { get; set; }
        public List<CategoryVm> Categories { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TaskManager.Domain.Models.Errand, AddErrandVm>().ReverseMap()
                .ForMember(d => d.CategoryId, opt => opt.MapFrom(s => s.CategoryId))
                .ForMember(d => d.StatusId, opt => opt.MapFrom(s => s.StatusId));
                //.ForMember(d => d.MyUserId, opt => opt.MapFrom(s => s.MyUserId));
        }
    }
}
