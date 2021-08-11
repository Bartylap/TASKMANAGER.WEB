using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;
using TaskManager.Domain.Models;

namespace TaskManager.Application.ViewModels.Construction
{
    public class AddConstructionVm : IMapFrom<TaskManager.Domain.Models.Construction>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Week { get; set; }
        public DateTime Date { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public bool Bufor { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddConstructionVm, TaskManager.Domain.Models.Construction>().ReverseMap();
        }

    }
}
