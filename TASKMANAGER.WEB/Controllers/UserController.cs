using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Application.Interfaces;
using TaskManager.Application.ViewModels.Errand;
using TaskManager.Application.ViewModels.User;

namespace TASKMANAGER.WEB.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IErrandServices _errService;

        public UserController(IUserService userService , IErrandServices errandServices)
        {
            _userService = userService;
            _errService = errandServices;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _userService.GetAllUser();
            return View(model);
        }
        public IActionResult Delete(string id)
        {
            _userService.DeleteUser(id);
            return RedirectToAction("Index");
        }

        public IActionResult MyErrands(string id)
        {
            var tasks = _userService.ViewTasks(id);
            return View(tasks);
        }


        [HttpGet]
        public IActionResult AddErrandtoUser(string id)
        {
            var model = _errService.GetUserForAddErrand(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult AddErrandtoUser(ErrandListForAddToUserVm model)
        {
            if (ModelState.IsValid)
            { 
            try
            {
                _errService.AddErrandToUser(model);
                
            }
            catch(Exception ex)
            {
                return View(ex.Message);
            }
            }
            ModelState.AddModelError("", "Error1");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string id)
        {
            var model = _userService.GetUser(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Details(UserVm model)
        {
            _userService.UpdateUser(model);
            return RedirectToAction("Index");

        }
    }
}
