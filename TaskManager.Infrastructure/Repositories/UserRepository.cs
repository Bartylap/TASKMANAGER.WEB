using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;

namespace TaskManager.Infrastructure.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }



        public IQueryable<MyUser> GetAllUsers()
        {
            return _context.MyUsers ;
          
        }

        public IQueryable<Domain.Models.Errand> GetMyTask(string userId)
        {
            var tasks = (from t in _context.Errands
                         join u in _context.MyUserErrands
                         on t.Id equals u.ErrandId
                         where u.MyUserId == userId
                         select t);

            return tasks;
        }

        public Domain.Models.MyUser GetUser(string userId)
        {
            return _context.MyUsers.FirstOrDefault(u => u.Id == userId);
        }

        public void RemoveUser(string id)
        {
            var user = _context.MyUsers.Find(id);
            _context.MyUsers.Remove(user);
            _context.SaveChanges();
        }
    }
}
