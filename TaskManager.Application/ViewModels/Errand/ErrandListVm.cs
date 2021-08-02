using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.ViewModels.Errand
{
    public class ErrandListVm
    {
        public List<ErrandVm> Errands { get; set; }
        public string SearchString { get; set; }
        public int Count { get; set; }
    }
}
