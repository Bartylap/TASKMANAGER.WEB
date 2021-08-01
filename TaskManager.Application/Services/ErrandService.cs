using AutoMapper;
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


        public int AddErrand(AddErandVm model)
        {
            var newerrand = _mapper.Map<Errand>(model);
            var id = _errRepo.AddErrand(newerrand);
            return id;

        }

        public void AddErrandToUser(ErrandListForAddToUserVm model)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public MyErrandListVm GetErandByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public ErrandVm GetErandToEdit(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CategoryVm> GetErrandCategory()
        {
            throw new NotImplementedException();
        }

        public IQueryable<StatusVm> GetErrandStatus()
        {
            throw new NotImplementedException();
        }

        public void UpdateErrand(ErrandVm errand)
        {
            throw new NotImplementedException();
        }
    }
}
