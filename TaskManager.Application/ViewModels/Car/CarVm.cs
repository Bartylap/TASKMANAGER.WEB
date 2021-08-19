using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.Car
{
    public class CarVm : IMapFrom<TaskManager.Domain.Models.Car>
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string Seats { get; set; }
        public string Year { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CarVm, TaskManager.Domain.Models.Car>().ReverseMap();
        }
    }
}
