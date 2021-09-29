using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.ViewModels.Construction
{
    public class AddItemToConstructionListVm
    {
        public List<AddItemToConstructionVm> Items { get; set; }
        public int ConstructionId { get; set; }
        public int ItemId { get; set; }
        public int Count { get; set; }
    }
}
