using EmployeeTarcking.Data.Contracts;
using EmployeeTarcking.Data.DataContext;
using EmployeeTarcking.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTarcking.Data.Implementaion
{
    public class EmployeeLeaveTypeRepository: Repository<EmployeeLeaveType> , IEmployeeLeaveType
    {
        private readonly EmployeeTrackingContext _ctx;
        public EmployeeLeaveTypeRepository(EmployeeTrackingContext ctx) : base(ctx)
        {

        }
    }
}
