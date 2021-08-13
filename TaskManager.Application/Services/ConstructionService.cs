using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Construction;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;

namespace TaskManager.Application.Services
{
    public class ConstructionService : IConstructionService
    {
        private readonly IConstructionRepository _conRepo;
        private readonly IMapper _mapper;
        public ConstructionService(IConstructionRepository conRepo, IMapper mapper)
        {
            _conRepo = conRepo;
            _mapper = mapper;
        }

        public int AddConstruction(AddConstructionVm model)
        {
            var cstr = _mapper.Map<Construction>(model);
            var id = _conRepo.AddConstruction(cstr);
            return id;
        }

        public ConstructionListVm GetAllConstruction(string searchString)
        {
            var construstions = _conRepo.GetAllConstruction().Where(c => c.Name.Contains(searchString))
                .ProjectTo<ConstructionVm>(_mapper.ConfigurationProvider).ToList();
            var cstrList = new ConstructionListVm
            {
                Constructions = construstions,
                Count = construstions.Count
            };
            return cstrList;
        }

        public DetailsConstructionVm GetConstruction(int id)
        {
            var cost =_conRepo.GetConstruction(id);
            var model = _mapper.Map<DetailsConstructionVm>(cost);
            return model;
        }

        public void UpdateConstruction(DetailsConstructionVm model)
        {
            var cstr = _mapper.Map<Construction>(model);
            _conRepo.UpdateConsrtuction(cstr);
        }
    }
}
