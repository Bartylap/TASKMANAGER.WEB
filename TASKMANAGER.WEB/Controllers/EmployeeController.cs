using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Employee;

namespace TASKMANAGER.WEB.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _empServ;


        public EmployeeController(IEmployeeService empServ)
        {
            _empServ = empServ;

        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _empServ.GetAllEmployee("");
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(string searchString)
        {
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var model = _empServ.GetAllEmployee(searchString);
            return View(model);
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View(new AddEmployeeVm());
        }
        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeVm model)
        {
            var id = _empServ.AddEmploye(model);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEmployee(int id)
        {
            _empServ.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditEmployee(int id)
        {
            var model = _empServ.GetEmployee(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditEmployee(EmployeeVm model)
        {
            _empServ.UpdateEmployee(model);
            return RedirectToAction("Index");
        }




    }
}
