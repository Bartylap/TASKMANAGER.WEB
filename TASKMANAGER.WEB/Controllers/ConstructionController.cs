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

            var model = _cstr.GetAllConstruction("");
            return View(model);
 
        }
        [HttpPost]
        public IActionResult Index(string searchString)
        {
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var model = _cstr.GetAllConstruction(searchString);
            return View(model);
        }

        [HttpGet]
        public IActionResult AddConstruction()
        {
            var model = new AddConstructionVm();
            model.Date = DateTime.Now;
           
            
            return View(model);
        }
        [HttpPost]
        public IActionResult AddConstruction(AddConstructionVm model)
        {
            _cstr.AddConstruction(model);
            return RedirectToAction("Index");
        }
    }
}
