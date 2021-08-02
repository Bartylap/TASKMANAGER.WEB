using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Errand;
using TaskManager.Domain.Interfaces;

namespace TASKMANAGER.WEB.Controllers
{
    public class ErrandController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IErrandServices _errServ;

        public ErrandController(IErrandServices errServ, IMapper mapper)
        {
            _errServ = errServ;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var errands = _errServ.GetAllErand("");
            return View(errands);
        }
        [HttpPost]
        public IActionResult Index(string searchString)
        {
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var errands = _errServ.GetAllErand(searchString);
            return View(errands);
        }
        [HttpGet]
        public IActionResult AddErrand()
        {
            var model = new AddErrandVm();
            model.Categories = _errServ.GetErrandCategory().ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddErrand(TaskManager.Application.ViewModels.Errand.AddErrandVm model)
        {
            var id = _errServ.AddErrand(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var errand = _errServ.GetErandToEdit(id);
            errand.Categories = _errServ.GetErrandCategory().ToList();
            errand.Statuses = _errServ.GetErrandStatus().ToList();
            return View(errand);
        }
        [HttpPost]
        public IActionResult Edit(ErrandVm model)
        {
            _errServ.UpdateErrand(model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _errServ.DeleteErrand(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View(new CategoryVm());
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryVm model)
        {
            _errServ.AddNewCategory(model);
            return RedirectToAction("Index");
        }
    }
}
