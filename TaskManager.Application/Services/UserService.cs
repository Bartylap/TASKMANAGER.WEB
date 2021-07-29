using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.User;

namespace TaskManager.Application.Services
{
    public class UserService : IUserService
    {
        public string AddUser(AddUserVm user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public UserListVm GetAllUsers(string searchString)
        {
            throw new NotImplementedException();
        }

        public UserVm GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserVm user)
        {
            throw new NotImplementedException();
        }
    }
}
