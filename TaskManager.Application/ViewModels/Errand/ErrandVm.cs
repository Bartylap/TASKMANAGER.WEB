using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.Errand
{
    public class ErrandVm : IMapFrom<TaskManager.Domain.Models.Errand>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsChecked { get; set; }
        public string MyUserId { get; set; }
        public int CategoryId { get; set; }
        public int StatusId { get; set; }
        public List<CategoryVm> Categories { get; set; }
        public List<StatusVm> Statuses { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TaskManager.Domain.Models.Errand, ErrandVm>().ReverseMap();
        }

    }
}
