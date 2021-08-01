using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Interfaces;

namespace TaskManager.Infrastructure.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }



        public IQueryable<Domain.Models.User> GetAllUsers()
        {
            return _context.User;
        }

        public IQueryable<Domain.Models.Errand> GetMyTask(string userId)
        {
            var tasks = (from t in _context.Errands
                         join u in _context.UserErrands
                         on t.Id equals u.ErrandId
                         where u.UserId == userId
                         select t);

            return tasks;
        }

        public Domain.Models.User GetUser(string userId)
        {
            return _context.User.FirstOrDefault(u => u.Id == userId);
        }

        public void RemoveUser(string id)
        {
            var user = _context.User.Find(id);
            _context.Remove(user);
        }
    }
}
