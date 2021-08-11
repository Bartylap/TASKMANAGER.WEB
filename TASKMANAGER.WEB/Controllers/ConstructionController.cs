using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Construction;

namespace TASKMANAGER.WEB.Controllers
{
    public class ConstructionController : Controller
    {
        private readonly IConstructionService _cstr;

        public ConstructionController(IConstructionService cstr)
        {
            _cstr = cstr;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(string searchString)
        {

            return View();
        }
        [HttpGet]
        public IActionResult AddConstruction()
        {
            return View(new AddConstructionVm());
        }
        [HttpPost]
        public IActionResult AddConstruction(AddConstructionVm model)
        {
            _cstr.AddConstruction(model);
            return RedirectToAction("Index");
        }
    }
}
