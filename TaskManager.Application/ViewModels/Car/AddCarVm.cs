using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;
using TaskManager.Domain.Models;

namespace TaskManager.Application.ViewModels.Car
{
    public class AddCarVm : IMapFrom<TaskManager.Domain.Models.Car>
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string Seats { get; set; }
        public string Year { get; set; }
        public DateTime CarInsurance { get; set; }
        public DateTime CarReview { get; set; }
        public string Tires { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddCarVm, TaskManager.Domain.Models.Car>().ReverseMap();
        }
    }
}
