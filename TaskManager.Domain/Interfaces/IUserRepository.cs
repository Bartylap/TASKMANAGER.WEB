using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Models;

namespace TaskManager.Domain.Interfaces
{
    public interface IUserRepository
    {
        public User GetUser(string UserId);
        IQueryable<User> GetAllUsers();
        void RemoveUser(string id);
        IQueryable<Errand> GetMyTask(string userId);
    }
}
