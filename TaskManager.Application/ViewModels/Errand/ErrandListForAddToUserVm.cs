using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.ViewModels.Errand
{
    public class ErrandListForAddToUserVm
    {
        public string MyUserId { get; set; }
        public int ErrandId { get; set; }
        public List<ErrandVm> Errands { get; set; }
    }
}
