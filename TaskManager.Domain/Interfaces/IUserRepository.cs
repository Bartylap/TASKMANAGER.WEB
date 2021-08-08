using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Models;

namespace TaskManager.Domain.Interfaces
{
    public interface IUserRepository
    {
        MyUser GetUser(string UserId);
        IQueryable<MyUser> GetAllUsers();
        void RemoveUser(string id);
        IQueryable<Errand> GetMyTask(string userId);
        void UpdateUser(MyUser user);
    }
}
