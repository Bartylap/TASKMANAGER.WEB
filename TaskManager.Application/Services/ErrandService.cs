using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Errand;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;

namespace TaskManager.Application.Services
{
    public class ErrandService : IErrandServices
    {
        private readonly IMapper _mapper;
        private readonly IErrandRepository _errRepo;
        public ErrandService(IMapper mapper , IErrandRepository errRepo)
        {
            _mapper = mapper;
            _errRepo = errRepo;
        }


        public int AddErrand(AddErrandVm model)
        {
            var newerrand = _mapper.Map<Errand>(model);
            var id = _errRepo.AddErrand(newerrand);
            return id;

        }

        public void AddNewCategory(CategoryVm category)
        {
            var newCategory = _mapper.Map<Category>(category);
             _errRepo.AddCategory(newCategory);
            
        }

        public void DeleteErrand(int id)
        {
            _errRepo.RemoveErrand(id);
        }

        public ErrandListVm GetAllErand(string searchString)
        {
            var errands = _errRepo.GetAll().Where(e => e.Name.Contains(searchString))
                .ProjectTo<ErrandVm>(_mapper.ConfigurationProvider).ToList();
            var errandsList = new ErrandListVm()
            {
                Errands = errands,
                Count= errands.Count
            };
            return errandsList;
        }
        public IQueryable<CategoryVm> GetErrandCategory()
        {
            var category = _errRepo.GetErrandsCategory().ProjectTo<CategoryVm>(_mapper.ConfigurationProvider);
            return category;
        }

        public IQueryable<StatusVm> GetErrandStatus()
        {
            var status = _errRepo.GetErrandsStatus().ProjectTo<StatusVm>(_mapper.ConfigurationProvider);
            return status;
        }

        public ErrandVm GetErandToEdit(int id)
        {
            var errand = _errRepo.GetErrand(id);
            var errandVm = _mapper.Map<ErrandVm>(errand);
            return errandVm;
        }

        public void UpdateErrand(ErrandVm model)
        {
            var errand = _mapper.Map<Errand>(model);
            _errRepo.UpdateErrand(errand);
        }
        public MyErrandListVm GetErandByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }


        public void AddErrandToUser(ErrandListForAddToUserVm model)
        {
            throw new NotImplementedException();
        }
    }
}
