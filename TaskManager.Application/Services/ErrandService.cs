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
        private readonly IUserRepository _userRepo;
        public ErrandService(IMapper mapper , IErrandRepository errRepo, IUserRepository userRepo)
        {
            _mapper = mapper;
            _errRepo = errRepo;
            _userRepo = userRepo;
        }


        public int AddErrand(AddErrandVm model)
        {
            var newerrand = _mapper.Map<Errand>(model);
            newerrand.StatusId = 1;
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



        public ErrandListForAddToUserVm GetUserForAddErrand(string id)
        {
            var user = _userRepo.GetUser(id);
            var tasks = _errRepo.GetAll()
                .ProjectTo<ErrandVm>(_mapper.ConfigurationProvider).ToList();
            var tasksList = new ErrandListForAddToUserVm
            {
                MyUserId = id,
                Errands = tasks
            };
            return tasksList;
        }

        public void AddErrandToUser(ErrandListForAddToUserVm model)
        {
            MyUserErrand result = new MyUserErrand();
            foreach (var t in model.Errands)
            {
                if (t.IsChecked == true)
                {
                    var mue = new MyUserErrand()
                    {
                        MyUserId = model.MyUserId,
                        ErrandId = t.Id
                    };
                    result = mue;
                }
            }
            _errRepo.AddErrandToUser(result);
        }

    }
}
