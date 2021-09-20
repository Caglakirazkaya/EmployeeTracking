using EmployeeTarcking.Data.Contracts;
using EmployeeTarcking.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTarcking.Data.Implementaion
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeTrackingContext _ctx;
        public UnitOfWork(EmployeeTrackingContext ctx)
        {
            _ctx = ctx;
            employeeLeaveAllocation = new EmployeeLeaveAllocationRepository(_ctx);
            employeeLeaveRequest = new EmployeeLeaveRequestRepository(_ctx);
            employeeLeaveType = new EmployeeLeaveTypeRepository(_ctx);
        }
        public IEmployeeLeaveAllocation employeeLeaveAllocation { get; private set; }
        public IEmployeeLeaveRequest employeeLeaveRequest { get; private set; }
        public IEmployeeLeaveType employeeLeaveType { get; set; }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }
    }
}
