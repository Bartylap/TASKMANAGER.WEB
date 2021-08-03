using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.ViewModels.User
{
    public class UserListVm
    {
        public List<UserVm> Users { get; set; }
        public string SearchString { get; set; }
        public int Count { get; set; }
    }
}
