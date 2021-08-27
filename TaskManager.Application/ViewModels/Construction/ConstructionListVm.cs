using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Application.Mapping;

namespace TaskManager.Application.ViewModels.Construction
{
    public class ConstructionListVm 
    {
        public List<ConstructionVm> Constructions { get; set; }
        public int Count { get; set; }

    }
}
