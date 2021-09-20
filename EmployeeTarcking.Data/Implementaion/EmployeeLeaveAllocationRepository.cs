using EmployeeTarcking.Data.Contracts;
using EmployeeTarcking.Data.DataContext;
using EmployeeTarcking.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTarcking.Data.Implementaion
{
    public class EmployeeLeaveAllocationRepository :Repository<EmployeeLeaveAllocation> , IEmployeeLeaveAllocation
    {
        private readonly EmployeeTrackingContext _ctx;
        public EmployeeLeaveAllocationRepository(EmployeeTrackingContext ctx):base(ctx) 
        {
            _ctx = ctx;
        }
    }
}
