using EmployeeTarcking.Data.Contracts;
using EmployeeTarcking.Data.DataContext;
using EmployeeTarcking.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTarcking.Data.Implementaion
{
    public class EmployeeLeaveRequestRepository : Repository<EmployeeLeaveRequest>, IEmployeeLeaveRequest
    {
        private readonly EmployeeTrackingContext _ctx;
        public EmployeeLeaveRequestRepository(EmployeeTrackingContext ctx) : base(ctx)
        {

        }
    }
}
