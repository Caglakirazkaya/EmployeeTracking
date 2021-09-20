using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTarcking.Data.Contracts
{
    public interface IUnitOfWork:IDisposable
    {
        public IEmployeeLeaveAllocation employeeLeaveAllocation { get; }
        public IEmployeeLeaveRequest employeeLeaveRequest { get;  }
        public IEmployeeLeaveType employeeLeaveType { get; }
        void Save();
    }
}
