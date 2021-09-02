using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Application.Mapping;
using TaskManager.Domain.Models;

namespace TaskManager.Application.ViewModels.Construction
{
    public class DetailsConstructionVm : IMapFrom<TaskManager.Domain.Models.Construction>
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public bool Bufor { get; set; }

        public List<CarsListAtTheConstructionVm> Car { get; set; }
        public List<FlatListAtTheConstructionVm> Flat { get; set; }
        public List<ToolListAtTheConstructionVm> Tolls { get; set; }

        public IList<EmployeeListAtTheConstructionVm> Employee { get; set; }


        public void Mapping(Profile profile)
        {


            profile.CreateMap<DetailsConstructionVm, TaskManager.Domain.Models.Construction>().ReverseMap()
                 .ForMember(a => a.Id, opt => opt.MapFrom(b=>b.Id))
                 .ForMember(a => a.Car, opt => opt.MapFrom(b => b.Car))
                 .ForMember(a => a.Flat, opt => opt.MapFrom(b => b.Flat))
                 .ForMember(a => a.Tolls, opt => opt.MapFrom(b => b.Tolls))
                 .ForMember(a => a.Employee, opt => opt.MapFrom(x => x.ConstructionEmployees.Select(y => y.Employee).ToList()));
        }
    }
}
