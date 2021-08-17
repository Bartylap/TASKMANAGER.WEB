using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.Construction
{
    public class CarsListAtTheConstructionVm : IMapFrom<TaskManager.Domain.Models.Car>
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string Seats { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TaskManager.Domain.Models.Car, CarsListAtTheConstructionVm>().ReverseMap();
        }
    }
}
