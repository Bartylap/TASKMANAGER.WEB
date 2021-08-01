using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.ViewModels.User;

namespace TaskManager.Application.Interfaces
{
    public interface IUserService
    {
        UserListVm GetAllUsers(string searchString);
        UserVm GetUser(string id);
        void DeleteUser(string id);
        void UpdateUser(UserVm user);
        MyErrandsListVm ViewTasks(string userId);

    }
}
