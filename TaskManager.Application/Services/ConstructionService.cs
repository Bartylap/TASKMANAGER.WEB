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
        private readonly IEmployeeRepository _empRepo;
        private readonly IMapper _mapper;
        public ConstructionService(IConstructionRepository conRepo, IMapper mapper, IEmployeeRepository empRepo)
        {
            _conRepo = conRepo;
            _empRepo = empRepo;
            _mapper = mapper;
        }
        public AddConstructionVm GetToClone(int id)
        {
            var cost = _conRepo.GetConstruction(id);
            var model = _mapper.Map<AddConstructionVm>(cost);
            return model;
        }
        public int Copy(int id)
        {
            var cost = _conRepo.GetConstruction(id);
            var newModel = (Construction)cost.Clone();
            _conRepo.AddConstruction(newModel);
            return newModel.Id;

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
        //----------------------//
        public AddEmployeeToConstructionList AddEmployeeToConstructionView(int id)
        {
            var employees = _empRepo.GetAllUser()
                .ProjectTo<AddEmployeeToConstruction>(_mapper.ConfigurationProvider).ToList();
            var model = new AddEmployeeToConstructionList()
            {
                ConstructionId = id,
                Employee = employees,
                Count = employees.Count
            };
            return model;
        }
        public void AddEmployeeToConstruction(AddEmployeeToConstructionList model)
        {

            foreach (var e in model.Employee)
            {
                if (e.Check == true)
                {
                    var ce = new ConstructionEmployee()
                    {
                        ConstructionId = model.ConstructionId,
                        EmployeeId = e.Id                
                    };
                    _conRepo.AddEmployeeToConstruction(ce);
                }
            }
        }


        //public void AddErrandToUser(ErrandListForAddToUserVm model)
        //{
        //    MyUserErrand result = new MyUserErrand();

        //    foreach (var t in model.Errands)
        //    {
        //        if (t.IsChecked == true)
        //        {
        //            var mue = new MyUserErrand()
        //            {
        //                MyUserId = model.MyUserId,
        //                ErrandId = t.Id
        //            };
        //            result = mue;

        //        }
        //    }
        //}


        }
    }
