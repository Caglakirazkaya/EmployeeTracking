using EmployeeTarcking.Data.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTarcking.Data.DataContext
{
    public class EmployeeTrackingContext : IdentityDbContext
    {
        public EmployeeTrackingContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeLeaveAllocation> EmployeeLeaveAllocations { get; set; }
        public DbSet<EmployeeLeaveRequest> EmployeeLeaveRequests { get; set; }
        public DbSet<EmployeeLeaveType> EmployeeLeaveTypes { get; set; }
    }
}
