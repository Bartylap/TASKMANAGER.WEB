using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.ViewModels.Car
{
    public class CarsListVm
    {
        public List<CarVm> Cars { get; set; }
        public int Count { get; set; }
        public string SearchString { get; set; }
    }
}
