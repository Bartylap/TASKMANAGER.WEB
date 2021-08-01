﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.User
{
    public class UserVm : IMapFrom<TaskManager.Domain.Models.User>
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<UserVm, TaskManager.Domain.Models.User>().ReverseMap()
                .ForMember(d => d.FullName, opt => opt.MapFrom(s => s.FirstName + " " + s.LastName));
        }
    }
}
