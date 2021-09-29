using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Warehouse;

namespace TASKMANAGER.WEB.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IWarehouseService _warService;

        public WarehouseController(IWarehouseService warService)
        {
            _warService = warService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _warService.GetAllItems("");
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(string searchString)
        {
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var items = _warService.GetAllItems(searchString);
            return View(items);
        }
        [HttpGet]
        public IActionResult AddItem()
        {
            var model = new AddItemVm();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddItem(AddItemVm model)
        {
            _warService.AddItems(model);
            return RedirectToAction("Index");
        }
    }
}
