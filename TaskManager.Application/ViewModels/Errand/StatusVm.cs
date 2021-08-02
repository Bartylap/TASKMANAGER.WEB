using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;
using TaskManager.Domain.Models;

namespace TaskManager.Application.ViewModels.Errand
{
    public class StatusVm: IMapFrom<Status>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Status, StatusVm>().ReverseMap();
    }
    }
}
