using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.ViewModels.User
{
    public class MyErrandsListVm
    {
        public List<ViewMyErrandsVm> Errands { get; set; }
        public int Count { get; set; }
        public string UserId { get; set; }
    }
}
