using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Errand;
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

        public ErrandListVm ViewTasks(string userId)
        {
            var errands = _userRepo.GetMyTask(userId)
                .ProjectTo<ErrandVm>(_mapper.ConfigurationProvider).ToList();

            var taskList = new ErrandListVm()
            {
                Errands = errands,
                Count = errands.Count
            };
            return taskList;
        }

        public void UpdateUser(UserVm model)
        {
            var user = _mapper.Map<MyUser>(model);
            _userRepo.UpdateUser(user);
        }
    }
}
