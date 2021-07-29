using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Errand;

namespace TaskManager.Application.Services
{
    public class ErrandService : IErrandServices
    {
        public int AddErand(AddErandVm erand)
        {
            throw new NotImplementedException();
        }

        public void AddErrandToUser(ErrandListForAddToUserVm model)
        {
            throw new NotImplementedException();
        }

        public int AddNewCategory(CategoryVm category)
        {
            throw new NotImplementedException();
        }

        public void DeleteErrand(int id)
        {
            throw new NotImplementedException();
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
