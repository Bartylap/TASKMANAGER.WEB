using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Car;
using TaskManager.Application.ViewModels.Construction;

namespace TASKMANAGER.WEB.Controllers
{
    public class ConstructionController : Controller
    {
        private readonly IConstructionService _cstr;
        private readonly ICarService _carServ;

        public ConstructionController(IConstructionService cstr, ICarService carServ)
        {
            _carServ = carServ;
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
        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = _cstr.GetConstruction(id);
            return View(model);
        }
        //[HttpPost]
        //public IActionResult Details(DetailsConstructionVm model)
        //{
        //    _cstr.UpdateConstruction(model);
        //    return RedirectToAction("Index");
        //}



        [HttpGet]
        public IActionResult Clone(int id)
        {
            _cstr.Copy(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult AddEmployeeToConstruction(int id)
        {
            var model = _cstr.AddEmployeeToConstructionView(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult AddEmployeeToConstruction(AddEmployeeToConstructionList model)
        {
            _cstr.AddEmployeeToConstruction(model);
            return RedirectToAction("Details" , new{id = model.ConstructionId } );
        }





        //----------------------------------------------------------------CARS-------------------------------------------------------------------//
        //----------------------------------------------------------------CARS-------------------------------------------------------------------//
        [HttpGet]
        public IActionResult Cars()
        {

            var model = _carServ.GetAllCars("");
            return View(model);

        }
        [HttpPost]
        public IActionResult Cars(string searchString)
        {
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var model = _carServ.GetAllCars(searchString);
            return View(model);
        }
        [HttpGet]
        public IActionResult Addcars()
        {

            return View(new AddCarVm());

        }
        [HttpPost]
        public IActionResult Addcars(AddCarVm models)

        {
            _carServ.AddCar(models);
            return RedirectToAction("Cars");

        }

    }
}
