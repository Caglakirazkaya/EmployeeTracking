using EmployeeTarcking.Data.DbModels;
using EmployeeTracking.Common.ResultModels;
using EmployeeTracking.Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTracking.BusinessEngine.Contracts
{
    public interface IEmployeeLeaveTypeBusinessEngine
    {
        Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveTypes();//AddVM
        Result<EmployeeLeaveTypeVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model);
        /// <summary>
        /// Get Employee Leave Type By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Result<EmployeeLeaveTypeVM> GetAllEmployeeLeaveType(int id);

        Result<EmployeeLeaveTypeVM> UpdateEmployeeLeaveType(EmployeeLeaveTypeVM model);

    }
}
