using EmployeeTracking.BusinessEngine.Contracts;
using EmployeeTracking.BusinessEngine.Implementaion;
using EmployeeTracking.Common.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTracking.UI.Controllers
{
    public class EmployeeLeaveTypeController : Controller
    {
        private readonly IEmployeeLeaveTypeBusinessEngine _employeeLeaveTypeBusinessEngine;
        public EmployeeLeaveTypeController(IEmployeeLeaveTypeBusinessEngine employeeLeaveTypeBusinessEngine)
        {
            _employeeLeaveTypeBusinessEngine = employeeLeaveTypeBusinessEngine;
        }  
        public IActionResult Index()
        {
            var data = _employeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveTypes();
            if (data.IsSuccess)
            {
                var result = data.Data;
                return View(result);
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeLeaveTypeVM employeeLeaveTypeVM)
        {
            if(ModelState.IsValid)
            {
                var data = _employeeLeaveTypeBusinessEngine.CreateEmployeeLeaveType(employeeLeaveTypeVM);
                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(data);
            }
            else
            return View(employeeLeaveTypeVM);
        }
        public IActionResult Edit(int id)
        {
            var data = _employeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveType(id);
            if(data.IsSuccess)
            {
                return View(data.Data);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Edit(EmployeeLeaveTypeVM employeeLeaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var data = _employeeLeaveTypeBusinessEngine.UpdateEmployeeLeaveType(employeeLeaveTypeVM);
                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(data);
            }
            else
                return View(employeeLeaveTypeVM);
        }
    }
}
