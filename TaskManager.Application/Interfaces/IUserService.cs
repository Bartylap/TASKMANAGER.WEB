using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.ViewModels.Errand;
using TaskManager.Application.ViewModels.User;

namespace TaskManager.Application.Interfaces
{
    public interface IUserService
    {
        UserListVm GetAllUser();
        UserVm GetUser(string id);
        void DeleteUser(string id);
        void UpdateUser(UserVm user);
        ErrandListVm ViewTasks(string userId);

    }
}
