using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.User;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;

namespace TaskManager.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public UserService(IMapper mapper, IUserRepository userRepo )
        {
            _mapper = mapper;
            _userRepo = userRepo;
        }



        public void DeleteUser(string id)
        {
            _userRepo.RemoveUser(id);
        }

        public UserListVm GetAllUser()
        {
            var users = _userRepo.GetAllUsers().ProjectTo<UserVm>(_mapper.ConfigurationProvider).ToList();

        var userList = new UserListVm()
            {

                Users = users,
                Count = users.Count
            };
            return userList;
        }

        public UserVm GetUser(string id)
        {
            var user = _userRepo.GetUser(id);
            var userVm = _mapper.Map<UserVm>(user);
            return userVm;
        }

        public MyErrandsListVm ViewTasks(string userId)
        {
            var errands = _userRepo.GetMyTask(userId)
                .ProjectTo<ViewMyErrandsVm>(_mapper.ConfigurationProvider).ToList();

            var taskList = new MyErrandsListVm()
            {
                Errands = errands,
                Count = errands.Count
            };
            return taskList;
        }

        public void UpdateUser(UserVm user)
        {
            throw new NotImplementedException();
        }
    }
}
