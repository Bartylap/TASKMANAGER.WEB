using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.Construction
{
    public class FlatListAtTheConstructionVm : IMapFrom<TaskManager.Domain.Models.Construction>
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string FlatNumber { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string RoomsNumber { get; set; }
        public int AvailableCapacity { get; set; }



        public void Mapping(Profile profile)
        {
            profile.CreateMap<FlatListAtTheConstructionVm,TaskManager.Domain.Models.Construction> ().ReverseMap();
        }

    }
}
