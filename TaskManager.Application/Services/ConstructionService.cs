using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Domain.Interfaces;

namespace TaskManager.Application.Services
{
    public class ConstructionService : IConstructionService
    {
        private readonly IConstructionRepository _conRepo;
        private readonly IMapper _mapper;
        public ConstructionService(IConstructionRepository conRepo, IMapper mapper)
        {
            _conRepo = conRepo;
            _mapper = mapper;
        }

    }
}
