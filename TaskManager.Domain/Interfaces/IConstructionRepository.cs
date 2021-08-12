﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Domain.Models;

namespace TaskManager.Domain.Interfaces
{
    public interface IConstructionRepository
    {
        int AddConstruction(Construction cstr);
        IQueryable<Construction> GetAllConstruction();
    }
}