using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Application.Interfaces;

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
            var model = _userService.GetAllUsers();
            return View(model);
        }
        public IActionResult Delete(string id)
        {
            _userService.DeleteUser(id);
            return RedirectToAction("Index");
        }
        public IActionResult MyErrads(string id)
        {
            var tasks = _userService.ViewTasks(id);
            return View(tasks);
        }

        //[HttpGet]
        //public IActionResult AddTaskToUser(string id)
        //{
        //    var model = _taskService.GetUserForAddTask(id);
        //    return View(model);
        //}
        //[HttpPost]
        //public IActionResult AddTaskToUser(TaskListForAddToUserVm model)
        //{
        //    _taskService.AddTaskTouser(model);
        //    return RedirectToAction("Index");
        //}
    }
}
